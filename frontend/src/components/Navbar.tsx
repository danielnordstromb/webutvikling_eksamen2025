import { NavLink } from "react-router-dom";

const navItems = [
  {
    to: "/athletes",
    label: "Administering",
  },
  {
    to: "/register",
    label: "Register athlete",
  },
  {
    to: "/dashboard",
    label: "Dashboard",
  },
];

export default function Navbar() {
  return (
    <nav className="border-b border-slate-800 bg-slate-950/90 backdrop-blur">
      <div className="mx-auto flex max-w-7xl items-center justify-between px-4 py-3 lg:px-8">
        {/* Logo / title */}
        <div className="flex items-center gap-2">
          <div className="flex h-8 w-8 items-center justify-center rounded-xl bg-indigo-500 text-xs font-bold text-slate-950">
            NBA
          </div>
          <div className="flex flex-col">
            <span className="text-sm font-semibold text-slate-100">
              Athlete Manager
            </span>
            <span className="text-[11px] uppercase tracking-[0.18em] text-slate-500">
              Admin panel
            </span>
          </div>
        </div>

        {/* Links */}
        <div className="flex items-center gap-2 text-sm">
          {navItems.map((item) => (
            <NavLink
              key={item.to}
              to={item.to}
              className={({ isActive }) =>
                [
                  "rounded-full px-3 py-1.5 transition",
                  "text-xs font-medium",
                  isActive
                    ? "bg-indigo-500 text-slate-950 shadow-sm shadow-indigo-500/60"
                    : "text-slate-300 hover:bg-slate-800 hover:text-slate-100",
                ].join(" ")
              }
            >
              {item.label}
            </NavLink>
          ))}
        </div>
      </div>
    </nav>
  );
}
