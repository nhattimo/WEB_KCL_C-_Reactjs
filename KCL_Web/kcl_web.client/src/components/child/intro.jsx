import React from 'react';
import "./intro.css"
const Intro = (intro) => {
return (
  <div className="col-md-6">
    <div className=" custom-card-intro card custom-card ">
      <div className="row ">
        <div className="col-md-6">
          <img src={intro.img} className="card-img" alt="" />
        </div>
        <div className="col-md-6">
          <div className="card-body">
            <h5 className="card-title">{intro.title}</h5>
            <p className="card-text">
              {intro.subtitle}
            </p>
            <a href={intro.link} className="btn btn-orange">Xem thêm</a>
          </div>
        </div>
      </div>
    </div>
  </div>
)}
export default Intro;