
import React, { Component } from "react";
import Slider from "react-slick";
import Partner from "./Partner/Partner";
import "./Partner.css"
import {
 Banner
} from "../components"



const images = [
    '../../public/image/client-logo/FPT.png',
    '../../public/image/client-logo/ALFA.png',
    '../../public/image/client-logo/Dnes.png',
    '../../public/image/client-logo/IBM.png',
    '../../public/image/client-logo/Viettel.png',
    '../../public/image/client-logo/Riavita.png',
    '../../public/image/client-logo/vnpt.png',
    
    // Thêm các tệp hình ảnh khác
  ];


  
function SampleNextArrow(props) {
    const { className, style, onClick } = props;
    return (
      <div
        className={className}
        style={{ ...style, display: "block"}}
        onClick={onClick}
      />
    );
  }
  
  function SamplePrevArrow(props) {
    const { className, style, onClick } = props;
    return (
      <div
        className={className}
        style={{ ...style, display: "block",}}
        onClick={onClick}
      />
    );
  }

function PartnerHome() {
    const a = 'https://fpt.com/-/media/project/fpt-corporation/fpt/news/2024/04/mou-fpt-nvidia.jpg';
    const imagePaths = images.map(image => image.default);
    console.log(imagePaths);

    const settings = {
        dots: true,
        infinite: true,
        slidesToShow: 3,
        slidesToScroll: 1,
        nextArrow: <SampleNextArrow />,
        prevArrow: <SamplePrevArrow />
      };

return( 
<>
<Banner img={a}title="ĐỐI TÁC-KHÁCH HÀNG    " />
<div className="container">

<div className="partener ">
    <div className="row ">
        <Partner/>
        <Partner/>
        <Partner/>
    </div>
</div >

<div className="slider-container partener-slick ">
        <Slider {...settings}>
          {images.map((imagePath, index) => (
            <div className="img-card" key={index}>
              <img src={imagePath} alt={`Image ${index}`} />
            </div>
          ))}
        </Slider>
      </div>
</div>

</>
)}
export default PartnerHome;