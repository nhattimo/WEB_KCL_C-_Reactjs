import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App.jsx';
import './index.css';
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import "@fortawesome/fontawesome-free/css/all.min.css";
import "./animate/animate.min.css";

import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import {
  Navigation,
  Footer,
  Home,
  K_SOLUTION,
  K_TECHNICAL,
  K_HEALTHTECH,
  News,
  Partn,
  History,
  Corevalues,
  Mission
} from "./components";

import Admin from './admin/App.jsx';
import AdminLayout from './admin/Adminlayout.jsx';

ReactDOM.createRoot(document.getElementById('root')).render(
  <Router>
    <Routes>
      <Route path="/" element={
        <>
          <Navigation />
          <Home />
          <Footer className="footer" />
        </>
      } />
      <Route path="/Lichsu" element={
        <>
          <Navigation />
          <History />
          <Footer className="footer" />
        </>
      } />
      <Route path="/Sumenh" element={
        <>
          <Navigation />
          <Mission />
          <Footer className="footer" />
        </>
      } />
      <Route path="/GiaTri" element={
        <>
          <Navigation />
          <Corevalues />
          <Footer className="footer" />
        </>
      } />
      <Route path="/DoiTac" element={
        <>
          <Navigation />
          <Partn />
          <Footer className="footer" />
        </>
      } />
      <Route path="/News" element={
        <>
          <Navigation />
          <News />
          <Footer className="footer" />
        </>
      } />
      <Route path="/SanPham/solution" element={
        <>
          <Navigation />
          <K_SOLUTION />
          <Footer className="footer" />
        </>
      } />
      <Route path="/SanPham/healthtech" element={
        <>
          <Navigation />
          <K_HEALTHTECH />
          <Footer className="footer" />
        </>
      } />
      <Route path="/SanPham/technical" element={
        <>
          <Navigation />
          <K_TECHNICAL />
          <Footer className="footer" />
        </>
      } />
      <Route path="/admin" element={
        <AdminLayout>
          <Admin />
        </AdminLayout>
      } />
    </Routes>
  </Router>
);
