import React from "react";
import "./style/aboutitem.css"
function AboutItem() {
    return(
  <div>
    <div className="container-fluid py-5">
      <div className="bg-2 bg-centre"></div>
      <div className="container">
        <div className="row g-5 ">
          <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
            <h1 className="mb-4">
            Phát triển bền vững
            </h1>
            <p className="mb-4">
            Công ty KCL là doanh nghiệp khoa học và công nghệ.
            </p>
            <div className="row g-3">
              <div className="col-sm-6">
                <h6 className="mb-3">
                  <i className="fa fa-check text-primary me-2" />
                  Award Winning
                </h6>
                <h6 className="mb-0">
                  <i className="fa fa-check text-primary me-2" />
                  Professional Staff
                </h6>
              </div>
              <div className="col-sm-6">
                <h6 className="mb-3">
                  <i className="fa fa-check text-primary me-2" />
                  24/7 Support
                </h6>
                <h6 className="mb-0">
                  <i className="fa fa-check text-primary me-2" />
                  Fair Prices
                </h6>
              </div>
            </div>
            <div className="d-flex align-items-center mt-4">
              <a className="btn btn-orange rounded-pill px-4 me-3" href="">
                Tìm Hiểu Thêm
              </a>
              <a className="btn btn-outline-primary btn-square me-3" href="">
                <i className="fab fa-facebook-f" />
              </a>
              <a className="btn btn-outline-primary btn-square me-3" href="">
                <i className=" fa-regular fa-envelope"></i>
              </a>
            </div>
          </div>
          <div className="col-lg-6 " data-wow-delay="0.1s">
    
      <div className="row parallelogram ">
        <div className="back auto"></div>
        <img className=" " src="../../../public/image/about-img.jpg" alt="" /></div>
    </div>
        </div>
      </div>
      <div className="container">
        <div className="row g-5 ">
          <div className="col-lg-6  wow fadeIn" data-wow-delay="0.1s">
    
              <div className="row parallelogram ">
                <div className="back auto  jalign-self-start"></div>
                <img className="auto align-self-end" src="../../../public/image/about-img.jpg" alt="" /></div>
            </div>
    
          <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
    
            <h1 className="mb-4">
            ĐỐI TÁC - kHÁCH HÀNG
            </h1>
            <p className="mb-4">
            Công ty KCL là doanh nghiệp khoa học và công nghệ chuyên cung cấp các giải pháp, sản phẩm, dịch vụ công nghệ thông tin
            </p>
              <div className="row g-3">
              <div className="col-sm-6">
                <h6 className="mb-3">
                  <i className="fa fa-check text-primary me-2" />
                  ĐỐI TÁC CHIẾN LƯỢC
                </h6>
                <h6 className="mb-0">
                  <i className="fa fa-check text-primary me-2" />
                  kHÁCH HÀNG CỦA CHÚNG TÔI
                </h6>
              </div>
    
            </div>
            <div className="d-flex align-items-center mt-4">
              <a className="btn btn-orange rounded-pill px-4 me-3" href="">
                Tìm Hiểu Thêm
              </a>
              <a className="btn btn-outline-primary btn-square me-3" href="">
                <i className="fab fa-facebook-f" />
              </a>
              <a className="btn btn-outline-primary btn-square me-3" href="">
                <i className=" fa-regular fa-envelope"></i>
              </a>
            </div>
          </div>
        </div>
      </div>
  </div>
  </div>



    );
}
export default AboutItem;