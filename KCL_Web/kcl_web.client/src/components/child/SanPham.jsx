import React from "react";
import { Link } from "react-router-dom";




const Chill_SanPham =(SanPham)=> {
  return (
    <div className="home">
      <div className="container">
     
          <div className="row align-items-center">
            <div className="col-lg-6">
              <img
                className="img-fluid rounded mb-4 mb-lg-0"
                src={SanPham.img}
                alt=""
              />
            </div>
            <div className="col-lg-6">
              <h1 className="font-weight-light">{SanPham.title}</h1>
              <p>
                {SanPham.subtitle}
              </p>
            </div>
          </div>
      </div>
      </div>
  )}




export default Chill_SanPham;
