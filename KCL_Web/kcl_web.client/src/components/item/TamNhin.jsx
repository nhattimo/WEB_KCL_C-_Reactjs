import React from "react";
import "./style/tamnhin.css";
import image from "../../../public/image/banner2.jpg";

const TamNhin = (vision) => {
  
  const icon1 = "https://fpt.com/-/media/project/fpt-corporation/fpt/home/our-mission/operative/kinh-doanh.svg";
  const icon2 = "https://fpt.com/-/media/project/fpt-corporation/fpt/home/our-mission/forceful/cong-nghe.svg";
  const icon3 = "https://fpt.com/-/media/project/fpt-corporation/fpt/home/our-mission/proficient/con-nguoi.svg";
  return (
    <div className="container-fluid">
      <div className="container TamNhin">

        <div className="row"  >

          <div className="col-lg-4">
            <h2 className="mb-4">Về KCL</h2>
            <div className="conten">
              <p>
                Công ty KCL là doanh nghiệp khoa học và công nghệ chuyên cung cấp các giải pháp,
                sản phẩm, dịch vụ công nghệ thông tin và viễn thông cho các cơ quan
              </p>
            </div>
            <a className="btn btn-orange" href="#">Xem Thêm</a>
          </div>

          <div className="col-lg-8">
            <div className="row">
              <div className="col-4">
                <div className="card custom-card-vision">
                  <div className="card-body custom-body">
                    <div>
                      <img src={icon1} alt="" />
                      <h5 className="card-title">TẦM NHÌN</h5>
                      <p className="card-text text-vision">Trở thành Công ty đáng tin cậy tại Miền Trung Tây Nguyên trong việc cung cấp các sản phẩm, dịch vụ, giải pháp ứng dụng Công nghệ Thông tin trong lĩnh vực Chăm sóc Sức khỏe cá nhân và Quản lý Y tế
                      </p>
                    </div>
                  </div>
                </div>
              </div>

              <div className="col-4">
                <div className="card custom-card-vision">
                  <div className="card-body custom-body">
                  <div>
                    <img src={icon2} alt="" />
                    <h5 className="card-title">TẦM NHÌN</h5>
                      <p className="card-text text-vision">Với triết lý phụng sự từ tâm, chúng tôi đam mê tạo ra những sản phẩm có giá trị trong việc nâng cao chất lượng Quản lý Y tế và Chăm sóc Sức khỏe cá nhân Chủ động - Toàn diện - Trọn đời cho người Việt, vì chất lượng cuộc sống người Việt
                      </p>
                  </div>
                  </div>
                </div>
              </div>

              <div className="col-4">
                <div className="card custom-card-vision">
                  <div className="card-body custom-body">
                  <div>
                    <img src={icon3} alt="" />
                    <h5 className="card-title">TẦM NHÌN</h5>
                      <p className="card-text text-vision">NHÂN – ĐOÀN KẾT chặt chẽ trong nội bộ; gắn bó mật thiết với khách hàng
                        <br />
                        LỄ - Luôn có thái độ lịch sự, TÔN TRỌNG khách hàng, đối tác
                      
                      </p>
                  </div>
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