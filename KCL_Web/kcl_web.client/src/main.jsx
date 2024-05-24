import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'

import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import {
  Navigation,
  Footer,
  Home,
  About,
  Contact,
  Tatca,
  K_SOLUTION,
  K_TECHNICAL,
  K_HEALTHTECH,
  Slide,

} from "./components";


ReactDOM.createRoot(document.getElementById('root')).render(
     <Router>
  <Navigation />
  
  <Routes>
    <Route path="/" element={<Home />} />
     <Route path="/about" element={<About />} />
    <Route path="/contact" element={<Contact />} />
    <Route path="/SanPham" element={<Tatca/>} />
    <Route path="/SanPham/solution" element={<K_SOLUTION />}/>
    <Route path="/SanPham/healthtech" element={<K_HEALTHTECH />} />
    <Route path="/SanPham//technical" element={<K_TECHNICAL />}/>
    {/* <Route path="/Admin" element={<Admin />} /> */}
  </Routes>
  <Footer claName="footer"/>
</Router> 


)

