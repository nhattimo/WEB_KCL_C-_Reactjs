import React from "react";

function AboutItem() {
    return(
        <>
  {/* About Start */}
  <div className="container-fluid py-5">
    <div className="container">
      <div className="row g-5 align-items-center">
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.1s">
          <div className="about-img">
            <img className="img-fluid" src="https://kclgroup.vn/introduction/ImgAbout.png" />
          </div>
        </div>
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
          <div className="btn btn-sm border rounded-pill text-primary px-3 mb-3">
            About Us
          </div>
          <h1 className="mb-4">
          KCL mang trên mình sứ mệnh cung cấp các giải pháp, sản phẩm,
           dịch vụ thông minh.
          </h1>
          <p className="mb-4">
          Công ty KCL là doanh nghiệp khoa học và công nghệ chuyên cung cấp các giải pháp, sản phẩm, dịch vụ công nghệ thông tin và viễn thông cho các cơ quan, doanh nghiệp trong và ngoài nước. Với đội ngũ các kỹ sư, 
            chuyên gia có hơn 20 năm kinh nghiệm trên các lĩnh vực, KCL là đơn vị tiên phong trong việc xây dựng các nền tảng công nghệ 4.0, phục vụ cho công cuộc chuyển đổi số của đất nước
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
            <a className="btn btn-primary rounded-pill px-4 me-3" href="">
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
  {/* About End */}
</>

    );
}
export default AboutItem;