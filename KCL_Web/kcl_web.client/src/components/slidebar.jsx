import Carousel from 'react-bootstrap/Carousel';
import React from 'react';
 import "../assets/slide.css"

function Slide() {
    return (
        <>
          <div className='justify-content-md-center'>
            <Carousel>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src="https://kclgroup.vn/api/images/sJTYx1w5cMuG6XIvLMiw/Brown%20Minimalist%20Home%20Interior%20Design%20Banner.png"
                  alt="First slide"
                />
                <Carousel.Caption>
                  <h5>First slide label</h5>
                  <p>Nulla vitae elit libero, a pharetra augue mollis interdum.</p>
                </Carousel.Caption>
              </Carousel.Item>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src="https://kclgroup.vn/api/images/wLvkFipEu14rjsGw36zW/Brown%20Minimalist%20Home%20Interior%20Design%20Banner%20(1).png"
                  alt="Second slide"
                />
                <Carousel.Caption>
                  <h5>Second slide label</h5>
                  <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                </Carousel.Caption>
              </Carousel.Item>
              <Carousel.Item>
                <img
                  className="d-block w-100"
                  src="https://kclgroup.vn/api/images/YQAWhID2AmByAsdVGz7m/Brown%20Minimalist%20Home%20Interior%20Design%20Banner.png"
                  alt="Third slide"
                />
                <Carousel.Caption>
                  <h5>Third slide label</h5>
                  <p>
                    Praesent commodo cursus magna, vel scelerisque nisl consectetur.
                  </p>
                </Carousel.Caption>
              </Carousel.Item>
            </Carousel>
          </div>
        </>
      );}

export default Slide;