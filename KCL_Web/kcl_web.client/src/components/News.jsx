import React, { useState, useEffect } from "react"; // Import useState and useEffect
import Slider from "react-slick";
import "slick-carousel/slick/slick.css";
import "slick-carousel/slick/slick-theme.css";
import CustomCard from "./mutiAbout/Customcard";
import Banner from "./child/banner";
import a3 from "../../public/image/banner3.jpg";
import "./New.css"


function News() {
  const settings = {
    dots: true,
    infinite: true,
    slidesToShow: 4,
    slidesToScroll: 4,
    
    //autoplay: true,
    // speed: 2000,
    // autoplaySpeed: 2000,
    initialSlide: 0,
    cssEase: "linear",
    responsive: [

      {
        breakpoint: 1024,
        settings: {
          dots: true,
          infinite: true,
          slidesToShow: 6,
          slidesToScroll: 2,
          vertical: true,
          verticalSwiping: true,
          beforeChange: function(currentSlide, nextSlide) {
            console.log("before change", currentSlide, nextSlide);
          },
          afterChange: function(currentSlide) {
            console.log("after change", currentSlide);
          }
        }
      },
    
    ]
  };

  const [posts, setPosts] = useState([]);

  useEffect(() => {
    Posts();
  }, []);

  async function Posts() {
    const response = await fetch('https://6657fb8a5c3617052646773f.mockapi.io/about');
    const data = await response.json();
    
    setPosts(data);
    console.log(data);
   
}
  return (
    <>
      <Banner img={a3} title="News" />
      <div className="container ">
          <div className="slider-container">
            <Slider {...settings}>
            {posts.map(post => (
              <div>
                <CustomCard
                  key={post.postId}
                  img={post.img}
                  title={post.title}
                  subtitle={post.subtitle}
                  link={post.link}
                  footer={`Last updated: ${post.footer}`}
                />
              </div>
                  ))}
            </Slider>
          </div>
    
      </div>
    </>
  );
}

export default News;
