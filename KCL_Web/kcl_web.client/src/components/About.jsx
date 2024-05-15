import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import "@fortawesome/fontawesome-free/css/all.min.css";

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
            src="img/hero-img.png"
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
  <div className="container-fluid py-5">
    <div className="container py-5">
      <div className="row g-5 align-items-center">
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.1s">
          <div className="about-img">
            <img className="img-fluid" src="img/about-img.jpg" />
          </div>
        </div>
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
          {/* <div className="btn btn-sm border rounded-pill text-primary px-3 mb-3">
            
          </div> */}
          <h1 className="mb-4">Tầm Nhìn </h1>
          <p className="mb-4">
          Trở thành Công ty đáng tin cậy tại Miền Trung Tây Nguyên trong việc cung cấp các sản phẩm,
           dịch vụ, giải pháp ứng dụng Công nghệ Thông tin trong lĩnh vực Chăm sóc Sức khỏe cá nhân và Quản lý Y tế

          </p>
          {/* <p className="mb-4">
            Aliqu diam amet diam et eos labore. Clita erat ipsum et lorem et
            sit, sed stet no labore lorem sit. Sanctus clita duo justo et
            tempor.
          </p> */}
          <div className="d-flex align-items-center mt-4">
            <a className="btn btn-primary rounded-pill px-4 me-3" href="">
              Read More
            </a>
          </div>
        </div>
      </div>
    </div>

    <div className="container py-5">
      <div className="row g-5 align-items-center">
        <div className="col-lg-6 wow fadeIn order-lg-last" data-wow-delay="0.1s">
          <div className="about-img">
            <img className="img-fluid" src="img/about-img.jpg" />
          </div>
        </div>
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
          <div className="btn btn-sm border rounded-pill text-primary px-3 mb-3">
            About Us
          </div>
          <h1 className="mb-4">Sứ Mệnh </h1>
          <p className="mb-4">
          Với triết lý phụng sự từ tâm, chúng tôi đam mê tạo ra những sản phẩm có giá trị trong việc nâng cao chất lượng Quản lý Y tế và Chăm sóc Sức khỏe cá nhân Chủ động - Toàn diện - Trọn đời cho người Việt, vì chất lượng cuộc sống người Việt 

          </p>
          <p className="mb-4">
            Aliqu diam amet diam et eos labore. Clita erat ipsum et lorem et
            sit, sed stet no labore lorem sit. Sanctus clita duo justo et
            tempor.
          </p>
          <div className="d-flex align-items-center mt-4">
            <a className="btn btn-primary rounded-pill px-4 me-3" href="">
              Read More
            </a>
          </div>
        </div>
      </div>
    </div>





    <div className="container py-5">
      <div className="row g-5 align-items-center">
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.1s">
          <div className="about-img">
            <img className="img-fluid" src="img/about-img.jpg" />
          </div>
        </div>
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
          <div className="btn btn-sm border rounded-pill text-primary px-3 mb-3">
            About Us
          </div>
          <h1 className="mb-4">We Make </h1>
          <p className="mb-4">
            Tempor erat elitr rebum at clita. Diam dolor diam ipsum et tempor
            sit. Aliqu diam amet diam et eos labore. Clita erat ipsum et lorem
            et sit, sed stet no labore lorem sit. Sanctus clita duo justo et
            tempor eirmod magna dolore erat amet
          </p>
          <p className="mb-4">
            Aliqu diam amet diam et eos labore. Clita erat ipsum et lorem et
            sit, sed stet no labore lorem sit. Sanctus clita duo justo et
            tempor.
          </p>
          <div className="d-flex align-items-center mt-4">
            <a className="btn btn-primary rounded-pill px-4 me-3" href="">
              Read More
            </a>
          </div>
        </div>
      </div>
    </div>

    <div className="container py-5">
      <div className="row g-5 align-items-center">
        <div className="col-lg-6 wow fadeIn order-lg-last" data-wow-delay="0.1s">
          <div className="about-img">
            <img className="img-fluid" src="img/about-img.jpg" />
          </div>
        </div>
        <div className="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
          <div className="btn btn-sm border rounded-pill text-primary px-3 mb-3">
            About Us
          </div>
          <h1 className="mb-4">We Make </h1>
          <p className="mb-4">
            Tempor erat elitr rebum at clita. Diam dolor diam ipsum et tempor
            sit. Aliqu diam amet diam et eos labore. Clita erat ipsum et lorem
            et sit, sed stet no labore lorem sit. Sanctus clita duo justo et
            tempor eirmod magna dolore erat amet
          </p>
          <p className="mb-4">
            Aliqu diam amet diam et eos labore. Clita erat ipsum et lorem et
            sit, sed stet no labore lorem sit. Sanctus clita duo justo et
            tempor.
          </p>
          <div className="d-flex align-items-center mt-4">
            <a className="btn btn-primary rounded-pill px-4 me-3" href="">
              Read More
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

export default About;
