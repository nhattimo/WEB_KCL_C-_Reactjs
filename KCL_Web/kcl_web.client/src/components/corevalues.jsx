import React from "react";
import "./CoreValues.css";
import Banner from "./child/banner";
import nhan from "../../public/image/giatri/nhan.png"
import bannerimg from "../../public/image/banner/giatricotloi.jpg"
function corevalues() {

      return (
        <>
        <Banner img={bannerimg} title="Giá trị cốt lõi" />
          <div className="corevalues">
            <div className="header bg-2">
              <h1>GIÁ TRỊ CỐT LÕI CỦA CHÚNG TÔI </h1>
              <p>NHÂN, LỄ, NGHĨA, TRÍ, TÍN là nền tảng để hình thành và phát triển của KCL, tạo nên sức mạnh và tinh thần thúc đẩy toàn thể nhân viên không ngừng nỗ lực, sáng tạo vì lợi ích chung của khách hàng, đối tác và cộng đồng.</p>
            </div>
            <div className="row1-container">
              <div className="box box-down cyan">
              <h2>Lễ</h2>
                <p>Luôn có thái độ lịch sự, TÔN TRỌNG khách hàng, đối tác</p>
                <img src="https://assets.codepen.io/2301174/icon-team-builder.svg" alt="" />
              </div>
            
              <div className="box red">
              <h2>NHÂN </h2>
                <p>ĐOÀN KẾT chặt chẽ trong nội bộ; gắn bó mật thiết với khách hàng
                </p>
                <img src={nhan} alt="" />
              </div>
              <div className="box box-down blue">
                <h2>Nghĩa</h2>
                <p>Tạo ra những sản phẩm đem lại Ý NGHĨA tốt đẹp cho cuộc sống
                </p>
                <img src="https://assets.codepen.io/2301174/icon-calculator.svg" alt="" />
              </div>
              <div className="hexagon"/>
            </div>
            <div className="row2-container">
              <div className="box orange">
                <h2>TRÍ</h2>
                <p>TRI THỨC và sự sáng tạo đem lại thành công</p>
                <img src="https://assets.codepen.io/2301174/icon-karma.svg" alt="" />
              </div>
              <div className="box green">
                <h2>Tín</h2>
                <p>Luôn đặt chữ TÍN lên hàng đầu.</p>
                <img src="https://assets.codepen.io/2301174/icon-karma.svg" alt="" />
              </div>
            </div>
     =
          </div>
        </>
      );
    }
  
    export default corevalues;