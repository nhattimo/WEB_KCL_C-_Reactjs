import React from "react";
import { Link } from "react-router-dom";
import "./hel.css"
import "@fortawesome/fontawesome-free/css/all.min.css";

import a1 from "../../../public/image/newsletter.png"
import a2 from "../../../public/image/project-1.jpg"
import Banner from "../../components/chill/banner.jsx"
function K_HEALTHTECH() {
  return (
    <>
    <Banner imageUlr={a2} />
     
      <div className="home ">
        <div className="container ">
          <Link to="/blog/this-is-a-post-title">
            <div className="row align-items-center my-5">
              <div className="col-lg-6">
                <img
                  className="img-fluid rounded mb-4 mb-lg-0"
                  src={a1}
                  alt=""
                />
              </div>
              <div className="col-lg-6">
                <h1 className="font-weight-light">K_HEALTHTECH</h1>
                <p>
                  Lorem Ipsum is simply dummy text of the printing and typesetting
                  industry. Lorem Ipsum has been the industry's standard dummy
                  text ever since the 1500s, when an unknown printer took a galley
                  of type and scrambled it to make a type specimen book.
                </p>
              </div>
            </div>
          </Link>
        </div>
        <div className="container">
          <Link to="/blog/this-is-a-post-title">
            <div className="row align-items-center my-5">
            <div className="col-lg-6">
                <h1 className="font-weight-light">K_HEALTHTECH</h1>
                <p>
                  Lorem Ipsum is simply dummy text of the printing and typesetting
                  industry. Lorem Ipsum has been the industry's standard dummy
                  text ever since the 1500s, when an unknown printer took a galley
                  of type and scrambled it to make a type specimen book.
                </p>
              </div>
              <div className="col-lg-6">
                <img
                  className="img-fluid rounded mb-4 mb-lg-0"
                  src={a2}
                  alt=""
                />
              </div>
            </div>
          </Link>
        </div>
        <div className="container">
          <Link to="/blog/this-is-a-post-title">
            <div className="row align-items-center my-5">
              <div className="col-lg-">
                <img
                  className="img-fluid rounded mb-4 mb-lg-0"
                  src="http://placehold.it/900x400"
                  alt=""
                />
              </div>
              <div className="col-lg-6">
                <h1 className="font-weight-light">K_HEALTHTECH</h1>
                <p>
                  Lorem Ipsum is simply dummy text of the printing and typesetting
                  industry. Lorem Ipsum has been the industry's standard dummy
                  text ever since the 1500s, when an unknown printer took a galley
                  of type and scrambled it to make a type specimen book.
                </p>
              </div>
            </div>
          </Link>
        </div>
      </div>
    </>
  );
}

export default K_HEALTHTECH;
