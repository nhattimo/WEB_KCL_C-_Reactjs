import React, { useState, useEffect } from 'react';
import { NavLink } from "react-router-dom";
import "./Navigation.css"
import Logo from "../../public/KCL-logo.svg"

const menu = () => {
}

const Navigation =(menu)=> {
  
  return (
    <div className="container-fluid header">
    <div className="container">
        <nav className="navbar navbar-expand-lg navbar p-0">   
                <div  className="navbar-brand">
                    <a href="/">
                        <h1 className><img src={Logo} alt="" /></h1>
                    </a>
                </div>
               <button type="button" className="navbar-toggler ms-auto me-0" data-bs-toggle="collapse" data-bs-target="#navbarCollapse">
                    <span className="navbar-toggler-icon" />
                </button> 
            <div className="collapse navbar-collapse" id="navbarCollapse">
                <div className="navbar-nav ">
    
                    <div className="nav-item dropdown">
                        <a href="/Lichsu" className="nav-link dropdown-toggle" data-bs-toggle="dropdown" >Về KCL</a>
                        <div className="dropdown-menu mt-2">
                            <a href="/Lichsu" className="dropdown-item">Lịch Sử</a>
                            <a href="/Giatri" className="dropdown-item">Giá Trị Cốt lõi</a>
                        </div>
                    </div>

                    <div className="nav-item dropdown">
                        <a href="/SanPham" className="nav-link dropdown-toggle " data-bs-toggle="dropdown" >Sản phẩm - Dịch vụ</a>
                        <div className="dropdown-menu mt-2">
                            <a href="/SanPham/solution" className="dropdown-item">K.SOLUTION</a>
                            <a href="/SanPham/healthtech" className="dropdown-item">K.HEALTHTECH </a>
                            <a href="/SanPham/technical" className="dropdown-item">K.TECHNICAL</a>
                        </div>
                    </div>
                    <a href="/DoiTac" className="nav-item nav-link">ĐỐI TÁC - KHÁCH HÀNG</a>
                    <a href="/News" className="nav-item nav-link">Tin Tức</a>
                    <a href="project.html" className="nav-item nav-link">CƠ HỘI NGHỀ NGHIỆP</a>
      
                </div>
                <butaton type="button" className="btn  p-0 d-none d-lg-block" data-bs-toggle="modal" data-bs-target="#searchModal"><i className="fa fa-search" /></butaton>
            </div>
        </nav>
    </div>    
</div>
  );
}

export default Navigation;
