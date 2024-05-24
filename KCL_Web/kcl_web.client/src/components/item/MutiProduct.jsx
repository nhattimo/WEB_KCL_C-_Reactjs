import React from 'react';
import "./style/product.css"
import logo_solution from "../../../public/image/LOGO_K_SOLUTION.jpg"
import logo_technical from "../../../public/image/LOGO TECHNICAL3.png"
import logo_healthtech from "../../../public/image/LOGO K.HEA vang.png"

function MutiProduct() {
    return (
        <>
        {/* Service Start */}
        <div className="container-fluid service mt-5 py-5">
          <div className="container py-5">
            <div className="row g-5 align-items-center">
              <div className="col-lg-12 wow fadeIn" data-wow-delay="0.1s">
                <div className="btn btn-sm border rounded-pill text-primary px-3 mb-3">
                  Our Services
                </div>
                <h1 className="mb-4">Sản Phẩm Của Chúng tôi</h1>
                <p className="mb-4">
                Các sản phẩm, dịch vụ của KCL đều được xây dựng trên nền tảng kết hợp công nghệ hiện đại của thế giới cùng với khả năng sáng tạo của các kỹ sư Việt nam. Lợi ích K.Clinic mang đến khách hàng đang sử dụng phần mềm: Quy trình làm việc tối ưu, minh bạch, nhanh chóng. Dữ liệu khách hàng đồng bộ, tập trung trong một phần mềm. Theo dõi sát sao bệnh án của khách hàng để chữa trị tốt nhất. 
                Phân công, giám sát hiệu quả công việc dễ dàng. Rút ngắn thời gian giải quyết công việc. Không còn tình trạng bỏ lỡ khách hàng
                </p>
                <a className="btn btn-primary rounded-pill px-4" href="">
                  Tìm Hiểu Thêm
                </a>
              </div>
              <div className="col-lg-12">
                <div className="row g-4">
                  <div className="col-md-6">
                    <div className="row g-4">
                      <div className="col-12 wow fadeIn" data-wow-delay="0.1s">
                        <div className="service-item d-flex flex-column justify-content-center text-center rounded">
                          <div className="service-icon btn-square">
                            <i>
                              <img src={logo_solution} alt="" />
                            </i>
                          </div>
                          <h5 className="mb-3">K.SOLUTION</h5>
                          <p>
                          - Phần mềm Quản lý Dự án Y tế
                          - Bệnh án điện tử
                          - Phần mềm Quản lý Phòng khám
                          - Tư vấn giải pháp CNTT trong Y tế
                          </p>
                          <a className="btn px-3 mt-auto mx-auto" href="">
                            Read More
                          </a>
                        </div>
                      </div>
                      <div className="col-12 wow fadeIn" data-wow-delay="0.5s">
                        <div className="service-item d-flex flex-column justify-content-center text-center rounded">
                          <div className="service-icon btn-square">
                            <i>
                              <img src={logo_technical} alt="" />
                            </i>
                          </div>
                          <h5 className="mb-3">K.TECHNICAL</h5>
                          <p>
                          - Phân phối Thiết bị Công nghệ
                          - Hạ tầng CNTT
                          - Giải pháp bảo mật
                          </p>
                          <a className="btn px-3 mt-auto mx-auto" href="">
                            Read More
                          </a>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div className="col-md-6 pt-md-4">
                    <div className="row g-4">
                      <div className="col-12 wow fadeIn" data-wow-delay="0.3s">
                        <div className="service-item d-flex flex-column justify-content-center text-center rounded">
                          <div className="service-icon btn-square">
                            <i>
                              <img src={logo_healthtech} alt="" />
                             </i>
                          </div>
                          <h5 className="mb-3"> K.HEALTHTECH</h5>
                          <p>
                          - Mô hình tư vấn & CSSK chủ động
                          - Phân phối sản phẩm Dược - TPCN
                          </p>
                          <a className="btn px-3 mt-auto mx-auto" href="">
                            Read More
                          </a>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        {/* Service End */}
      </>
    );
}

export default MutiProduct;