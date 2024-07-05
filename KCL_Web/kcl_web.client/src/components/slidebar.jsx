import Carousel from 'react-bootstrap/Carousel';
import React, { useEffect,useRef,useState   } from 'react';
import "../assets/slide.css"
import 'animate.css'; 


const Slide=()=> {
  const img = 'https://fpt.com/-/media/project/fpt-corporation/fpt/news/2024/04/mou-fpt-nvidia.jpg'
  const img2 ="https://fpt.com/-/media/project/fpt-corporation/fpt/news/2024/05/top-50-gartner_01.png"
  const slide = [
      {
        img: img,
        title: "KCL",
        h1: "KCL Group",
        p: "thông tin Công ty",
        link: "https://www.fpt.com/vi/",
     
      },
      {
        img: img2,
        title: "KCL",
        h1: "KCL Group",
        p: "Thông tin mới nhất",
        link: "https://www.fpt.com/vi/",
        footer: "KCL"
      }
    ];
    const carouselRef = useRef(null);
    const movingBoxRef = useRef(null);
    const [currentIndex, setCurrentIndex] = useState(0);
    useEffect(() => {
      if (carouselRef.current) { 
          carouselRef.current.addEventListener('slide.bs.carousel', handleSlide);
          // Loại bỏ sự kiện khi component unmounts
          return () => {
              carouselRef.current.removeEventListener('slide.bs.carousel', handleSlide);
          };
      };
      if (slideImage) {
        slideImage.classList.add('animate__flipInX');
        setTimeout(() => {
            slideImage.classList.remove('animate__flipOutX');
        }, 1000); // Thời gian của animation là 1s
    }
  }, [carouselRef]);

  const handleSlide = event => {
      const currentSlide = event.relatedTarget;
      const contentx = currentSlide.querySelector('.contentx');
    
      if (contentx) {
          contentx.classList.add('animate__fadeInDown');
          setTimeout(() => {
              contentx.classList.remove('animate__fadeInUp');
          }, 1000); // Thời gian của animation là 1s
      }
  };

    useEffect(() => {
      const handleSlide = (event) => {
        const nextIndex = event.to;
        setCurrentIndex(nextIndex);
        const { direction } = event; // Lấy thông tin hướng slide
        const offset = direction === 'left' ? '-100%' : '100%';
  
        // Đặt lại vị trí của moving-box cho slide tiếp theo
        movingBoxRef.current.style.transform = `translateX(${offset})`;
        // Sau một khoảng thời gian ngắn, đưa moving-box trở lại vị trí giữa
        setTimeout(() => {
          movingBoxRef.current.style.transition = 'transform 0s';
          movingBoxRef.current.style.transform = 'translateY(0)';
          // Sau khi thiết lập lại vị trí, bật lại transition
          setTimeout(() => {
            movingBoxRef.current.style.transition = 'transform 1s ease';
          }, 50); // Đợi một chút để đảm bảo rằng vị trí đã được thiết lập lại
        }, 500); // Thời gian khớp với thời gian chuyển đổi slide của carousel
      };
  
      const carouselElement = carouselRef.current;
      carouselElement.addEventListener('slide.bs.carousel', handleSlide);
  
      return () => {
        carouselElement.removeEventListener('slide.bs.carousel', handleSlide);
      };
    }, []);
    
   

  return (
    <>
    
      <div id="carouselcustom" className="carousel  " ref={carouselRef}  data-bs-ride="carousel" data-bs-interval={4000}>
        <div className="box1" >
        <div className="moving-box" ref={movingBoxRef}>
        {slide.map((item, index) => (
      <div
      key={index}
      className={`contentx text-center animate__fadeInDown  ${currentIndex === index ? 'd-block' : 'd-none'}`}
    >
                <div className="btn btn-sm border rounded-pill px-3 mb-3 animated">{item.title}</div>
                <h1 className="display-4 mb-4 animated ">{item.h1}</h1>
                <p className="mb-4 animated">{item.p}</p>
                <a href={item.link} className="btn btn-orange py-sm-3 px-sm-5 rounded-pill animated ">Xem Thêm</a>
              </div>
 
        ))}
           </div>
        </div>
        <div className="carousel-indicators">
          {slide.map((_, index) => (
            <button
              key={index}
              type="button"
              data-bs-target="#carouselcustom"
              data-bs-slide-to={index}
              className={index === 0 ? "active" : ""}
              aria-current={index === 0 ? "true" : "false"}
              aria-label={`Slide ${index + 1}`}
            />
          ))}
        </div>
        <div className="carousel-inner">
          {slide.map((item, index) => (
            <div key={index} className={`carousel-item ${index === 0 ? "active" : ""}`}   >

              <div className='slide-image animated" ' > 
                      <a href={item.link}>
                        <img className="img-fluid" src={item.img} alt={item.h1} />
                      </a>
                    </div>
                  </div>
          ))}
        
        </div>
        <button className="carousel-control-prev" type="button" data-bs-target="#carouselcustom" data-bs-slide="prev">
          <span className="carousel-control-prev-icon" aria-hidden="true" />
          <span className="visually-hidden">Previous</span>
        </button>
        <button className="carousel-control-next" type="button" data-bs-target="#carouselcustom" data-bs-slide="next">
          <span className="carousel-control-next-icon" aria-hidden="true" />
          <span className="visually-hidden">Next</span>
        </button>
      </div>

      <div className="box2 bg-2   " >
        <div className="moving-box" ref={movingBoxRef}>
        {slide.map((item, index) => (
      <div
      key={index}
      className={`contentx animate__backInUp ${currentIndex === index ? 'd-block' : 'd-none'}`}
    >
                <div className="btn btn-sm border  animated">{item.title}</div>
                <h1 className="display-4  animated ">{item.h1}</h1>
                <p className="mb-4 animated">{item.p}</p>
                <a href={item.link} className="btn btn-orange animated ">Xem Thêm</a>
              </div>
 
        ))}
           </div>
      </div>
    </>
  )
}

  export default Slide;