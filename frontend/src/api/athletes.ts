// frontend/src/api/athletes.ts

import type { Athlete } from "../types/athlete";

const API_BASE_URL = "http://localhost:5143/api"; // Samme port som backend-serveren

export async function fetchAthletes(): Promise<Athlete[]> {
  const res = await fetch(`${API_BASE_URL}/athlete`);
  if (!res.ok) {
    throw new Error("Failed to fetch athletes");
  }
  return res.json();
}

export async function deleteAthlete(id: number): Promise<void> {
  const res = await fetch(`${API_BASE_URL}/athlete/${id}`, {
    method: "DELETE",
  });
  if (!res.ok) {
    throw new Error("Failed to delete athlete");
  }
}

export async function updateAthlete(athlete: Athlete): Promise<Athlete> {
  const res = await fetch(`${API_BASE_URL}/athlete/${athlete.id}`, {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(athlete),
  });

  if (!res.ok) {
    throw new Error("Failed to update athlete");
  }

  return res.json();
}
