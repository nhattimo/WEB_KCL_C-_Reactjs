import React from "react";
import "./style/Topnew.css";

function TopNews() {
    return (
        <>
        <div className="container-fluid bg-light ">
          <div className="container">
            <div
              className="mx-auto wow fadeIn"
              data-wow-delay="0.1s" 
            > 
            <div className="row">
               
           
                  <h2 className="col align-self-start  mb-2">TIN TỨC NỔI BẬT</h2>
              

                    <a href="/" className="col-auto btn btn-orange align-self-end">Xem Thêm</a>

              </div>    
            </div>
            <div className="row g-4">
              <div className="col-lg-4 wow fadeIn" data-wow-delay="0.3s">
                <div className="case-item position-relative overflow-hidden rounded mb-2">
                  <img className="img-fluid" src="../../../public/image/project-1.jpg" alt="" />
                  <a className="case-overlay " href="">
                    <small>Biến Động Công nghệ</small>
                    <h5 className="lh-base mb-3">
                     Các phần mềm chat gặp những biến động mạnh
                    </h5>
                  </a>
                </div>
              </div>

              <div className="col-lg-4 wow fadeIn" data-wow-delay="0.5s">
                <div className="case-item position-relative overflow-hidden rounded mb-2">
                  <img className="img-fluid" src="../../../public/image/project-2.jpg" alt="" />
                  <a className="case-overlay " href="">
                    <small>Machine learning</small>
                    <h5 className="lh-base  mb-3">
                    Trí tuệ nhân tạo đang đạt được những bước tiến bộ vượt bậc
                    </h5>
                    
                  </a>
                </div>
              </div>
            
              <div className="col-lg-4 wow fadeIn" data-wow-delay="0.7s">
                <div className="case-item position-relative overflow-hidden rounded mb-2">
                  <img className="img-fluid" src="../../../public/image/project-3.jpg" alt="" />
                  <a className="case-overlay " href="">
                    <small>Predictive Analysis</small>
                    <h5 className="lh-base  mb-3">
                      Lo ngại về sự phát triển thần tốc của trí tuệ nhân tạo, thay thế con người
                    </h5>
                    
                  </a>
                </div>
              </div>
            </div>
          </div>
        </div>
        {/* Case End */}
      </>
    );
}      

export default TopNews;