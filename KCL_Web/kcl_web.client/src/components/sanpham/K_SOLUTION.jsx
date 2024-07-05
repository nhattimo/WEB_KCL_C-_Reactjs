import React from "react";
import "./Solution.css";
import Banner from "../child/banner.jsx"
import { Link } from "react-router-dom";
import a3 from "../../../public/image/25.jpg"
import Contencard from '../item/contenCard';
import {
  AboutItem,
} from "../../components";
function K_SOLUTION() {
  return (
    <>
   <Banner img={a3} title="K_HEALTHTECH" />
   <AboutItem />  
  <div className="br-1">
      <div className="container mt-5 br-1" >

          <div className="row align-items-center ">
            <div className="col-lg-6">
              
              <div  className="parallelogram" >
                <img
                  className="img-fluid rounded mb-4 mb-lg-0"
                  src="http://placehold.it/900x400"
                  alt=""
                />
              </div>
            </div>
            <div className="col-lg-6">
              <h1 className="font-weight-light">K_SoLution</h1>
              <p>
                Lorem Ipsum is simply dummy text of the printing and typesetting
                industry. Lorem Ipsum has been the industry's standard dummy
                text ever since the 1500s, when an unknown printer took a galley
                of type and scrambled it to make a type specimen book.
              </p>
            </div>
          </div>
        
      </div>
      </div>
      </>
  );
}

export default K_SOLUTION;
