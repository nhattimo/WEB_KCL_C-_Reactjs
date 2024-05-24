import React, { useState, useEffect } from 'react';
import { NavLink } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import "./Navigation.css";
import "@fortawesome/fontawesome-free/css/all.min.css";
// import "./Navigation.js"



function Navigation() {
    
  
  return (
    <div className="container-fluid header">
    <div className="container">
        <nav className="navbar navbar-expand-lg navbar p-0">
            <a href="/" className="navbar-brand">
                <h1 className>KCL</h1>
            </a>
            <button type="button" className="navbar-toggler ms-auto me-0" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
                <span className="navbar-toggler-icon" />
            </button>
            <div className="collapse navbar-collapse" id="navbarCollapse">
                <div className="navbar-nav ms-auto">
                    <a href="/about" className="nav-item nav-link">Về KCL</a>
                    <div className="nav-item dropdown">
                        <a href="/SanPham" className="nav-link dropdown-toggle" data-bs-toggle="dropdown">Sản phẩm - Dịch vụ</a>
                        <div className="dropdown-menu mt-2">
                            <a href="/SanPham/solution" className="dropdown-item">K.SOLUTION</a>
                            <a href="/SanPham/healthtech" className="dropdown-item">K.HEALTHTECH </a>
                            <a href="/SanPham//technical" className="dropdown-item">K.TECHNICAL</a>
                        </div>
                    </div>
                    <a href="service.html" className="nav-item nav-link">Tin Tức</a>
                    <a href="project.html" className="nav-item nav-link">Shop</a>
      
                </div>
                <butaton type="button" className="btn  p-0 d-none d-lg-block" data-bs-toggle="modal" data-bs-target="#searchModal"><i className="fa fa-search" /></butaton>
            </div>
        </nav>
    </div>    
</div>
  );
}

export default Navigation;
