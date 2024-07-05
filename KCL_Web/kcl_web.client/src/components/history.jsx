import React, { useEffect, useState } from 'react';
import './Timeline.css'; // Import your CSS file here
import Banner from './child/banner';
import a3 from "../../public/image/banner3.jpg";

import Card from "./child/SanPham.jsx";
const TIMELINE_VALUES = {
  start: 190,
  step: 30
};

const years = [
    {
      year: 2020,
      Image: 'https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg',
      events: [
        {
          title: 'PHÁT TRIỂN VÀ ỨNG DỤNG APP QUẢN LÝ XN CỘNG ĐỒNG'  ,
          subtitle: 'Công ty TNHH MTV CÔNG NGHỆ CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG '
        }
      ]
    },
    {
      year: 2021,
      Image: 'https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg',
      events: [
        {
          title: 'PHÁT TRIỂN VÀ ỨNG DỤNG APP QUẢN LÝ XN CỘNG ĐỒNG'  ,
          subtitle: 'Công ty TNHH MTV CÔNG NGHỆ CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG '
        }
      ]
    },
    {
      year: 2022,
      Image: 'https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg',
      events: [
        {
          title: 'PHÁT TRIỂN VÀ ỨNG DỤNG APP QUẢN LÝ XN CỘNG ĐỒNG',
          subtitle: 'Công ty TNHH MTV CÔNG NGHỆ CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG'
        }
      ]
    },
    {
      year: 2023,
      Image: 'https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg',
      events: [
        {
          title: 'PHÁT TRIỂN VÀ ỨNG DỤNG APP QUẢN LÝ XN CỘNG ĐỒNG',
          subtitle: 'Công ty TNHH MTV CÔNG NGHỆ CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG'
        }
      ]
    },
    {
      year: 2024,
      Image: 'https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg',
      events: [
        {
          title: 'PHÁT TRIỂN VÀ ỨNG DỤNG APP QUẢN LÝ XN CỘNG ĐỒNG',
          subtitle: 'Công ty TNHH MTV CÔNG NGHỆ CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG NGHỆ THÔNG TIN CÔNG TY CỔ PHẦN XÂY DỰNG CÔNG'
        }
      ]
    }
  ];

const history = () => {
    
    const [stickyTop, setStickyTop] = useState(0);
    const [scrollTarget, setScrollTarget] = useState(false);
    const [activeIndex, setActiveIndex] = useState(0);
  

    const [paddingBottom, setPaddingBottom] = useState(0);

    useEffect(() => {
      // Calculate padding-bottom dynamically
     const milestoneheight = document.querySelector('.milestone').offsetHeight;
      const calculatedPadding = milestoneheight- 70
      setPaddingBottom(calculatedPadding);

    }, [years]);    

    useEffect(() => {
      const timeline = document.querySelector('.timeline__nav');
      const milestones = document.querySelectorAll('.timeline__section .milestone');
      const offsetTop = parseFloat(window.getComputedStyle(timeline).top);  
      const bannerHeight = document.querySelector('.banner').offsetHeight;
      const handleResize = () => {
      
        setStickyTop(timeline.offsetTop - offsetTop);
        handleScroll();
      };
      const handleScroll = () => {
        if (window.scrollY > stickyTop) {
            timeline.classList.add('fixed');
        } else {
            timeline.classList.remove('fixed');
        }
    
        const viewLine = window.scrollY - 400;
        console.log(window.scrollY);
        console.log(viewLine);
        console.log(bannerHeight  );
        let active = -1;
    
        if (scrollTarget === false) {
            milestones.forEach((milestone, index) => {
                if (milestone.offsetTop - viewLine > 0) {
                    return false;
                }
                active++;
            });
        } else {
            active = scrollTarget;
        }
    
        timeline.style.top = `${active * TIMELINE_VALUES.step + TIMELINE_VALUES.start}px`;
        setActiveIndex(active !== -1 ? active : 0);
    };
  
  
      window.addEventListener('resize', handleResize);
      window.addEventListener('scroll', handleScroll);
  
      handleResize();
  
      return () => {
        window.removeEventListener('resize', handleResize);
        window.removeEventListener('scroll', handleScroll);
      };
    }, [stickyTop, scrollTarget]);
  
    return (
        <div> 
            <Banner img={a3} title="Giới thiệu" />
            <article className="timeline container">


            <div>
            <ul className="nav nav-tabs" id="myTab" role="tablist">
            <li className="nav-item" role="presentation">
                <button className="nav-link active" id="home-tab" data-bs-toggle="tab"
                 data-bs-target="#home-tab-pane" type="button" role="tab" 
                 aria-controls="home-tab-pane" aria-selected="true">CÁC MỐC LỊCH SỬ</button>
            </li>
            <li className="nav-item" role="presentation">
                <button className="nav-link" id="profile-tab" data-bs-toggle="tab" 
                data-bs-target="#profile-tab-pane" type="button" role="tab" 
                aria-controls="profile-tab-pane" aria-selected="false">HỘI ĐỒNG QUẢN TRỊ    </button>
            </li>
            </ul>
            <div className="tab-content" id="myTabContent">
            <div className="tab-pane fade show active" id="home-tab-pane" role="tabpanel" aria-labelledby="home-tab" tabIndex={0}>
            <nav className="timeline__nav">
              <ul>
                {years.map((item, index) => (
                     <a href={`#year-${item.year}`}>
                  <li style={{ paddingBottom: `${paddingBottom}px` }}
                    key={item.year}
                    className={activeIndex === index ? 'active' : ''}
                  >
                    <span>{item.year}</span>
                  </li>
                  </a>
                ))}
              </ul>
            </nav>
            <section className="timeline__section">
              <div className="wrapper" >
                {years.map((item, index) => (
                <div key={item.year} id={`year-${item.year}`} className="milestone">
                    <h2>{item.year}</h2>
                    
                    {item.events && item.events.map((event, eventIndex) => (
                        
                <div key={eventIndex} className="container">
                {/* Render your event component here */}
                <Card img={item.Image} title={event.title} subtitle={event.subtitle} />
                </div>
                ))}
                  </div>
                ))}
              </div>
            </section>
            </div>
            </div>
        </div>
        </article>
        </div>
    );
  };
  
export default history;
