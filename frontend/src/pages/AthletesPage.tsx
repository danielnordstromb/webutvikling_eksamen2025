// frontend/src/pages/AthletesPage.tsx

import { useEffect, useMemo, useState } from "react";
import type { Athlete } from "../types/athlete";
import { fetchAthletes, deleteAthlete, updateAthlete } from "../api/athletes";

type StatusFilter = "all" | "purchased" | "notPurchased";

const PAGE_SIZE = 20;

function formatPrice(n: number) {
  return `$ ${n
    .toLocaleString("fr-FR", { maximumFractionDigits: 0 })
    .replace(/\./g, " ")}`;
}



const AthletesPage = () => {
  const [athletes, setAthletes] = useState<Athlete[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const [search, setSearch] = useState("");
  const [statusFilter, setStatusFilter] = useState<StatusFilter>("all");
  const [positionFilter, setPositionFilter] = useState<string>("all");

  const [editing, setEditing] = useState<Athlete | null>(null);
  const [isSaving, setIsSaving] = useState(false);

  const [page, setPage] = useState(1);

  useEffect(() => {
    const load = async () => {
      try {
        setIsLoading(true);
        const data = await fetchAthletes();
        setAthletes(data);
      } catch (err) {
        console.error(err);
        setError("Klarte ikke å hente spillere.");
      } finally {
        setIsLoading(false);
      }
    };

    load();
  }, []);

  // Reset side når filtrene endres
  useEffect(() => {
    setPage(1);
  }, [search, statusFilter, positionFilter]);

  const positions = useMemo(() => {
    const unique = new Set(
      athletes
        .map((a) => a.position)
        .filter((p) => p && p.trim().length > 0)
    );
    return Array.from(unique).sort();
  }, [athletes]);

  const filteredAthletes = useMemo(() => {
    return athletes
      .filter((a) => {
        if (!search) return true;
        return a.name.toLowerCase().includes(search.toLowerCase());
      })
      .filter((a) => {
        if (statusFilter === "purchased") return a.purchaseStatus;
        if (statusFilter === "notPurchased") return !a.purchaseStatus;
        return true;
      })
      .filter((a) => {
        if (positionFilter === "all") return true;
        return a.position === positionFilter;
      });
  }, [athletes, search, statusFilter, positionFilter]);

  const totalPages = useMemo(() => {
    const pages = Math.ceil(filteredAthletes.length / PAGE_SIZE);
    return pages > 0 ? pages : 1;
  }, [filteredAthletes.length]);

  const paginatedAthletes = useMemo(() => {
    const start = (page - 1) * PAGE_SIZE;
    return filteredAthletes.slice(start, start + PAGE_SIZE);
  }, [filteredAthletes, page]);

  const handleDelete = async (id: number) => {
    if (!confirm("Slette denne spilleren?")) return;
    try {
      await deleteAthlete(id);
      setAthletes((prev) => prev.filter((a) => a.id !== id));
    } catch (err) {
      console.error(err);
      alert("Kunne ikke slette spilleren.");
    }
  };

  const startEdit = (athlete: Athlete) => {
    setEditing({ ...athlete });
  };

  const handleEditChange = (
    field: keyof Athlete,
    value: string | number | boolean
  ) => {
    if (!editing) return;
    setEditing({ ...editing, [field]: value } as Athlete);
  };

  const handleSaveEdit = async () => {
    if (!editing) return;
    try {
      setIsSaving(true);
      const updated = await updateAthlete(editing);
      setAthletes((prev) =>
        prev.map((a) => (a.id === updated.id ? updated : a))
      );
      setEditing(null);
    } catch (err) {
      console.error(err);
      alert("Kunne ikke lagre endringer.");
    } finally {
      setIsSaving(false);
    }
  };

  const showingFrom =
    filteredAthletes.length === 0 ? 0 : (page - 1) * PAGE_SIZE + 1;
  const showingTo = Math.min(page * PAGE_SIZE, filteredAthletes.length);

  return (
    <div className="min-h-screen bg-gradient-to-b from-slate-950 via-slate-900 to-slate-950 text-slate-100">
      <div className="mx-auto max-w-7xl px-4 py-8 lg:px-8">
        {/* Header */}
        <header className="mb-8 flex flex-col gap-6 md:flex-row md:items-center md:justify-between">
          <div>
            <p className="text-xs font-semibold uppercase tracking-[0.2em] text-indigo-400/80">
              NBA ADMIN
            </p>
            <h1 className="mt-2 text-3xl font-bold tracking-tight sm:text-4xl">
              Athletes Dashboard
            </h1>
            <p className="mt-2 text-sm text-slate-400">
              Administrer NBA-spillere, filtrer etter posisjon og status, og
              rediger statsene deres på en mer moderne måte enn et Excel-ark.
            </p>
          </div>

          {/* Search + filters */}
          <div className="flex w-full flex-col gap-3 rounded-2xl border border-slate-800 bg-slate-900/70 p-3 backdrop-blur-sm md:w-auto md:flex-row md:items-center md:justify-end">
            <div className="relative md:w-64">
              <input
                type="text"
                placeholder="Søk på navn..."
                value={search}
                onChange={(e) => setSearch(e.target.value)}
                className="w-full rounded-xl border border-slate-700 bg-slate-950/70 px-4 py-2 text-sm text-slate-100 placeholder-slate-500 focus:border-indigo-500 focus:outline-none focus:ring-2 focus:ring-indigo-500/30"
              />
              <span className="pointer-events-none absolute right-3 top-1/2 -translate-y-1/2 text-xs text-slate-500">
                ⌕
              </span>
            </div>

            <div className="flex flex-wrap gap-2">
              <select
                value={statusFilter}
                onChange={(e) =>
                  setStatusFilter(e.target.value as StatusFilter)
                }
                className="rounded-xl border border-slate-700 bg-slate-950/70 px-3 py-2 text-xs font-medium text-slate-100 focus:border-indigo-500 focus:outline-none focus:ring-2 focus:ring-indigo-500/30"
              >
                <option value="all">Alle statuser</option>
                <option value="notPurchased">Ikke kjøpt</option>
                <option value="purchased">Kjøpt</option>
              </select>

              <select
                value={positionFilter}
                onChange={(e) => setPositionFilter(e.target.value)}
                className="rounded-xl border border-slate-700 bg-slate-950/70 px-3 py-2 text-xs font-medium text-slate-100 focus:border-indigo-500 focus:outline-none focus:ring-2 focus:ring-indigo-500/30"
              >
                <option value="all">Alle posisjoner</option>
                {positions.map((pos) => (
                  <option key={pos} value={pos}>
                    {pos}
                  </option>
                ))}
              </select>
            </div>
          </div>
        </header>

        {/* Edit panel */}
        {editing && (
          <div className="mb-8 rounded-2xl border border-indigo-500/30 bg-slate-900/80 p-5 shadow-lg shadow-indigo-500/20 backdrop-blur">
            <div className="flex items-start justify-between gap-4">
              <div>
                <h2 className="text-lg font-semibold">
                  Rediger spiller ·{" "}
                  <span className="text-indigo-300">{editing.name}</span>
                </h2>
                <p className="text-xs text-slate-400">
                  Oppdater basisinfo og stats for spilleren.
                </p>
              </div>
              <button
                className="text-xs text-slate-400 hover:text-slate-200"
                onClick={() => setEditing(null)}
              >
                Lukk
              </button>
            </div>

            <div className="mt-4 grid gap-4 md:grid-cols-3">
              <div className="space-y-2">
                <label className="block text-xs text-slate-400">Navn</label>
                <input
                  type="text"
                  value={editing.name}
                  onChange={(e) => handleEditChange("name", e.target.value)}
                  className="w-full rounded-lg border border-slate-700 bg-slate-950 px-3 py-2 text-sm focus:border-indigo-500 focus:outline-none focus:ring-1 focus:ring-indigo-500/60"
                />
              </div>

              <div className="space-y-2">
                <label className="block text-xs text-slate-400">
                  Posisjon
                </label>
                <input
                  type="text"
                  value={editing.position}
                  onChange={(e) =>
                    handleEditChange("position", e.target.value)
                  }
                  className="w-full rounded-lg border border-slate-700 bg-slate-950 px-3 py-2 text-sm focus:border-indigo-500 focus:outline-none focus:ring-1 focus:ring-indigo-500/60"
                />
              </div>

              <div className="space-y-2">
                <label className="block text-xs text-slate-400">Land</label>
                <input
                  type="text"
                  value={editing.country}
                  onChange={(e) =>
                    handleEditChange("country", e.target.value)
                  }
                  className="w-full rounded-lg border border-slate-700 bg-slate-950 px-3 py-2 text-sm focus:border-indigo-500 focus:outline-none focus:ring-1 focus:ring-indigo-500/60"
                />
              </div>

              <div className="space-y-2">
                <label className="block text-xs text-slate-400">Pris</label>
                <input
                  type="number"
                  value={editing.price}
                  onChange={(e) =>
                    handleEditChange("price", Number(e.target.value))
                  }
                  className="w-full rounded-lg border border-slate-700 bg-slate-950 px-3 py-2 text-sm focus:border-indigo-500 focus:outline-none focus:ring-1 focus:ring-indigo-500/60"
                />
              </div>

              <div className="space-y-2">
                <label className="block text-xs text-slate-400">Høyde</label>
                <input
                  type="text"
                  value={editing.height}
                  onChange={(e) =>
                    handleEditChange("height", e.target.value)
                  }
                  className="w-full rounded-lg border border-slate-700 bg-slate-950 px-3 py-2 text-sm focus:border-indigo-500 focus:outline-none focus:ring-1 focus:ring-indigo-500/60"
                />
              </div>

              <div className="space-y-2">
                <label className="block text-xs text-slate-400">Vekt</label>
                <input
                  type="number"
                  value={editing.weight}
                  onChange={(e) =>
                    handleEditChange("weight", Number(e.target.value))
                  }
                  className="w-full rounded-lg border border-slate-700 bg-slate-950 px-3 py-2 text-sm focus:border-indigo-500 focus:outline-none focus:ring-1 focus:ring-indigo-500/60"
                />
              </div>
            </div>

            <div className="mt-4 flex justify-end gap-3">
              <button
                onClick={() => setEditing(null)}
                className="rounded-xl border border-slate-600 px-4 py-2 text-xs font-medium text-slate-200 hover:bg-slate-800"
                type="button"
              >
                Avbryt
              </button>
              <button
                onClick={handleSaveEdit}
                disabled={isSaving}
                className="rounded-xl bg-indigo-500 px-4 py-2 text-xs font-semibold text-white shadow shadow-indigo-500/30 hover:bg-indigo-600 disabled:cursor-not-allowed disabled:opacity-60"
                type="button"
              >
                {isSaving ? "Lagrer..." : "Lagre endringer"}
              </button>
            </div>
          </div>
        )}

        {/* Content */}
        {isLoading && (
          <div className="mt-16 text-center text-slate-400">
            Laster inn spillere...
          </div>
        )}

        {error && (
          <div className="mt-4 rounded-xl border border-red-500/40 bg-red-500/10 px-4 py-3 text-sm text-red-200">
            {error}
          </div>
        )}

        {!isLoading && !error && (
          <>
            {filteredAthletes.length === 0 ? (
              <div className="mt-12 text-center text-slate-500">
                Ingen spillere matcher filtrene.
              </div>
            ) : (
              <>
                {/* Grid med "NBA-kort" */}
                <div className="grid gap-6 sm:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4">
                  {paginatedAthletes.map((athlete) => (
                    <article
                      key={athlete.id}
                      className="group flex flex-col overflow-hidden rounded-3xl border border-slate-800/80 bg-slate-900/80 shadow-lg shadow-black/40 ring-1 ring-slate-800/60 transition hover:-translate-y-1 hover:border-indigo-500/60 hover:shadow-2xl hover:shadow-indigo-500/30"
                    >
                      <div className="relative aspect-[3/4] overflow-hidden bg-slate-800">
                        <img
                          src={athlete.image}
                          alt={athlete.name}
                          className="h-full w-full object-cover transition duration-300 group-hover:scale-105 group-hover:brightness-110"
                        />
                        {/* Gradient overlay bottom */}
                        <div className="pointer-events-none absolute inset-x-0 bottom-0 h-24 bg-gradient-to-t from-slate-950/95 via-slate-950/60 to-transparent" />

                        {/* Topp badges */}
                        <div className="absolute left-3 top-3 flex items-center gap-2">
                          <span className="rounded-full bg-slate-950/80 px-2 py-1 text-[10px] font-semibold uppercase tracking-wide text-slate-100">
                            {athlete.position || "Posisjon"}
                          </span>
                          <span className="rounded-full bg-indigo-500/90 px-2 py-1 text-[9px] font-semibold uppercase tracking-wide text-slate-950">
                            NBA
                          </span>
                        </div>

                        {athlete.purchaseStatus && (
                          <div className="absolute right-3 top-3 rounded-full bg-emerald-400 px-2 py-1 text-[9px] font-semibold uppercase tracking-wide text-emerald-950 shadow-sm shadow-emerald-500/60">
                            Kjøpt
                          </div>
                        )}
                      </div>

                      {/* Info / stats */}
                      <div className="flex flex-1 flex-col gap-3 p-4">
                        <div className="flex items-start justify-between gap-2">
                          <div>
                            <h2 className="text-base font-semibold text-slate-50 line-clamp-1">
                              {athlete.name}
                            </h2>
                            <p className="mt-1 text-[11px] text-slate-400">
                              {athlete.country} · {athlete.age} år
                            </p>
                          </div>
                          <span className="rounded-full border border-slate-700 bg-slate-900 px-2 py-1 text-[10px] uppercase tracking-wide text-slate-300">
                            {athlete.gender}
                          </span>
                        </div>

                        <div className="grid grid-cols-3 gap-2 rounded-2xl bg-slate-950/60 p-3 text-[11px]">
                          <div className="space-y-1">
                            <p className="text-[10px] uppercase tracking-wide text-slate-500">
                              Height
                            </p>
                            <p className="font-medium text-slate-100">
                              {athlete.height || "–"}
                            </p>
                          </div>
                          <div className="space-y-1">
                            <p className="text-[10px] uppercase tracking-wide text-slate-500">
                              Weight
                            </p>
                            <p className="font-medium text-slate-100">
                              {athlete.weight ? `${athlete.weight} lbs` : "–"}
                            </p>
                          </div>
                          <div className="space-y-1">
                            <p className="text-[10px] uppercase tracking-wide text-slate-500">
                              Value
                            </p>
                            <p className="font-semibold text-indigo-400">
                              {formatPrice(athlete.price)}
                            </p>
                          </div>
                        </div>

                        <div className="mt-2 flex gap-2">
                          <button
                            onClick={() => startEdit(athlete)}
                            className="flex-1 rounded-xl border border-slate-700 bg-slate-900/80 px-3 py-1.5 text-xs font-medium text-slate-100 transition hover:border-indigo-400 hover:bg-slate-900 hover:text-indigo-300"
                            type="button"
                          >
                            Rediger
                          </button>
                          <button
                            onClick={() => handleDelete(athlete.id)}
                            className="rounded-xl border border-red-500/70 bg-red-500/10 px-3 py-1.5 text-xs font-semibold text-red-300 transition hover:bg-red-500/20"
                            type="button"
                          >
                            Slett
                          </button>
                        </div>
                      </div>
                    </article>
                  ))}
                </div>

                {/* Pagination */}
                <div className="mt-8 flex flex-col items-center justify-between gap-3 text-xs text-slate-400 sm:flex-row">
                  <div>
                    Viser{" "}
                    <span className="font-semibold text-slate-100">
                      {showingFrom}–{showingTo}
                    </span>{" "}
                    av{" "}
                    <span className="font-semibold text-slate-100">
                      {filteredAthletes.length}
                    </span>{" "}
                    spillere
                  </div>
                  <div className="flex items-center gap-2">
                    <button
                      type="button"
                      onClick={() => setPage((p) => Math.max(1, p - 1))}
                      disabled={page === 1}
                      className="rounded-full border border-slate-700 bg-slate-900/70 px-3 py-1 text-xs font-medium text-slate-200 disabled:cursor-not-allowed disabled:opacity-40 hover:border-indigo-400 hover:text-indigo-300"
                    >
                      Forrige
                    </button>
                    <div className="flex items-center gap-1">
                      <span className="rounded-full bg-slate-900/80 px-3 py-1 text-[11px] font-medium text-slate-100">
                        Side {page} av {totalPages}
                      </span>
                    </div>
                    <button
                      type="button"
                      onClick={() =>
                        setPage((p) => Math.min(totalPages, p + 1))
                      }
                      disabled={page === totalPages || filteredAthletes.length === 0}
                      className="rounded-full border border-slate-700 bg-slate-900/70 px-3 py-1 text-xs font-medium text-slate-200 disabled:cursor-not-allowed disabled:opacity-40 hover:border-indigo-400 hover:text-indigo-300"
                    >
                      Neste
                    </button>
                  </div>
                </div>
              </>
            )}
          </>
        )}
      </div>
    </div>
  );
};

export default AthletesPage;
