import React from "react";
import "./style/tamnhin.css";
import image from "../../../public/image/banner2.jpg";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import "@fortawesome/fontawesome-free/css/all.min.css";

function TamNhin() {
   return( 
      <div className="container-fluid">
        <div className="container TamNhin">
            <div className="row"  >
                <div className="col-lg-6">
                  <h2 className="mb-4">Our mission</h2>
                  <div className="conten">
                    <p>r mission is to be the leading provider of innovative and cutting-edge artificial intelligence
                      solutions
                      that empower businesses and individuals to achieve their goals. We strive to push the
                      boundaries of what's
                      possible with AI, constantly exploring new frontiers and delivering transformative
                      technologies that unlock
                      new opportunities and drive progress.
                    </p>
                  </div>
                  <a className="btn btn-primary" href="#">Xem Thêm</a>
                </div>
                <div className="col-lg-6">
                  <div className="row">
                    <div className=" col-md-4">
                      <div className="card">
                        <img src="..." className="card-img-top" alt="..." />
                        <div className="card-body">
                          <p className="card-text">Some quick example text to build on the card title and make up
                            the bulk of the card's content.</p>
                        </div>
                      </div>
                    </div>
                    <div className=" col-md-4">
                      <div className="card">
                        <img src="..." className="card-img-top" alt="..." />
                        <div className="card-body">
                          <p className="card-text">Some quick example text to build on the card title and make up
                            the bulk of the card's content.</p>
                        </div>
                      </div>
                    </div>
                    <div className=" col-md-4">
                      <div className="card">
                        <img src="..." className="card-img-top" alt="..." />
                        <div className="card-body">
                          <p className="card-text">Some quick example text to build on the card title and make up
                            the bulk of the card's content.</p>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              </div>
            <div className="mision_bottom">
              <img src={image} alt="img" className="img-fluid" />
            </div>
          
      </div>
   )
}
export default TamNhin;