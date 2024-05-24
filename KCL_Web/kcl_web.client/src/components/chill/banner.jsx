import React from "react";
import './banner.css'
function banner({imageUlr}){

    return(
    
    <div className="banner">
   <img src={imageUlr} alt="" />
   </div>)
};

export default banner;