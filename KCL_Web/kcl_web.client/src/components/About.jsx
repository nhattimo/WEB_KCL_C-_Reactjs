import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import "@fortawesome/fontawesome-free/css/all.min.css";
import AboutCard from "./mutiAbout/aboutCard";

function About() {
  return (

<>
  {/* Hero Start */}
  <div className="container-fluid pt-5 bg-primary hero-header">
    <div className="container pt-5">
      <div className="row g-5 pt-5">
        <div className="col-lg-6 align-self-center text-center text-lg-start mb-lg-5">

          <h1 className="display-4 text-white mb-4 animated slideInRight">
            About Us
          </h1>
          
          <nav aria-label="breadcrumb">
            <ol className="breadcrumb justify-content-center justify-content-lg-start mb-0">
              <li className="breadcrumb-item">
                <a className="text-white" href="#">
                  Home
                </a>
              </li>
              <li className="breadcrumb-item">
                <a className="text-white" href="#">
                  Pages
                </a>
              </li>
              <li
                className="breadcrumb-item text-white active"
                aria-current="page"
              >
                About Us
              </li>
            </ol>
          </nav>

        </div>
        <div className="col-lg-6 align-self-end text-center text-lg-end">
          <img
            className="img-fluid"
            src="../../public/image/hero-img.png"
            alt=""
            style={{ maxHeight: 300 }}
          />

        </div>
      </div>
    </div>
  </div>
  {/* Hero End */}

  
  {/* Full Screen Search Start */}
  <div className="modal fade" id="searchModal" tabIndex={-1}>
    <div className="modal-dialog modal-fullscreen">
      <div
        className="modal-content"
        style={{ background: "rgba(20, 24, 62, 0.7)" }}
      >
        <div className="modal-header border-0">
          <button
            type="button"
            className="btn btn-square bg-white btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          />
        </div>
        <div className="modal-body d-flex align-items-center justify-content-center">
          <div className="input-group" style={{ maxWidth: 600 }}>
            <input
              type="text"
              className="form-control bg-transparent border-light p-3"
              placeholder="Type search keyword"
            />
            <button className="btn btn-light px-4">
              <i className="bi bi-search" />
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
  {/* Full Screen Search End */}


  {/* About Start */}
  <div className="container py-5">
    <div className="row">
    <AboutCard title="About Us" subtitle="Lorem ipsum dolor sit amet elit. Phasellus imperdiet, nulla et dictum interdum." 
    text="Tempor erat elit Scelerisque vitae pellentesque sit amet porttitor eget dolor. Justo nec ultrices dui sapien eget mi proin sed libero enim sed"
    footer="Copyright &copy; Your Website 2021. All Rights Reserved."/>
 


  <AboutCard title="About Us" subtitle="Lorem ipsum dolor sit amet elit. Phasellus imperdiet, nulla et dictum interdum." 
    text="Tempor erat elit Scelerisque vitae pellentesque sit amet porttitor eget dolor. Justo nec ultrices dui sapien eget mi proin sed libero enim sed"
    footer="Copyright &copy; Your Website 2021. All Rights Reserved."/>


<AboutCard title="About Us" subtitle="Lorem ipsum dolor sit amet elit. Phasellus imperdiet, nulla et dictum interdum." 
    text="Tempor erat elit Scelerisque vitae pellentesque sit amet porttitor eget dolor. Justo nec ultrices dui sapien eget mi proin sed libero enim sed"
    footer="Copyright &copy; Your Website 2021. All Rights Reserved."/>
    
<AboutCard title="About Us" subtitle="Lorem ipsum dolor sit amet elit. Phasellus imperdiet, nulla et dictum interdum." 
    text="Tempor erat elit Scelerisque vitae pellentesque sit amet porttitor eget dolor. Justo nec ultrices dui sapien eget mi proin sed libero enim sed"
    footer="Copyright &copy; Your Website 2021. All Rights Reserved."/>
</div>
</ div> 
  {/* About End */}
</>


  
  );
}

export default About;
