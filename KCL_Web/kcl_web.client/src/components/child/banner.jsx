import React from "react";
import './banner.css'
const banner = (banner) =>{

    return(
        <div className="banner">
           <img src={banner.img} alt="" />
           <div className="banner-title col-sm-12 col-md-12 col-lg-7">
           <span>{banner.title}</span>
           </div>
       </div>
)
};  

export default banner;