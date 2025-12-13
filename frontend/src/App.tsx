// frontend/src/App.tsx

import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import AthletesPage from "./pages/AthletesPage";
//import RegisterAthletePage from "./pages/RegisterAthletePage";
//import FinanceDashboardPage from "./pages/FinanceDashboardPage";
import Navbar from "./components/Navbar";

function App() {
  return (
    <BrowserRouter>
      <div className="min-h-screen bg-slate-950 text-slate-100">
        <Navbar />
        <main>
          <Routes>
            <Route path="/" element={<Navigate to="/athletes" replace />} />
            <Route path="/athletes" element={<AthletesPage />} />
            <Route path="/register" element={<AthletesPage />} />
            <Route path="/dashboard" element={<AthletesPage />} />
          </Routes>
        </main>
      </div>
    </BrowserRouter>
  );
}

export default App;
