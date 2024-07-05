import React from "react";
import { MDBFooter, MDBContainer, MDBRow, MDBCol, MDBIcon } from 'mdb-react-ui-kit';
 import  './Footer.css';


function Footer() {
  return (
    <MDBFooter bgColor='light' className='text-center text-lg-start text-muted'>
      <section className='d-flex justify-content-left justify-content-lg-left p-4 border-bottom'>
        <div className='me-5 d-none d-lg-block'>
          <span>Liên hệ với chúng tôi:</span>
        </div>

        <div>
          <a href='' className='me-4 text-reset'>
            <MDBIcon color='secondary' fab icon='facebook-f' />
          </a>
          <a href='' className='me-4 text-reset'>
            <MDBIcon color='secondary' fab icon='twitter' />
          </a>
          <a href='' className='me-4 text-reset'>
            <MDBIcon color='secondary' fab icon='google' />
          </a>
          <a href='' className='me-4 text-reset'>
            <MDBIcon color='secondary' fab icon='instagram' />
          </a>
          <a href='' className='me-4 text-reset'>
            <MDBIcon color='secondary' fab icon='linkedin' />
          </a>
          <a href='' className='me-4 text-reset'>
            <MDBIcon color='secondary' fab icon='github' />
          </a>
        </div>
      </section>

      <section className=''>
        <MDBContainer className='text-center text-md-start mt-5 mb-4'>
          <MDBRow className='mt-6'>

          <MDBCol md='4' lg='3' xl='3' className='mx-auto mb-md-0 mb-4'>
              <h6 className='text-uppercase fw-bold mb-4'>LIÊN HỆ VỚI CHÚNG TÔI</h6>
              <p>
                <MDBIcon color='secondary' icon='home' className='me-2' />
                160 Lê Đình Lý, Vĩnh Trung, Thanh Khê, Đà Nẵng, Việt Nam
              </p>
              <p>
                <MDBIcon color='secondary' icon='envelope' className='me-3' />
                kclgroup.@gmail.com
              </p>
              <p>
                <MDBIcon color='secondary' icon='phone' className='me-3' /> 0932 070 463 
              </p>
              <p>
                <MDBIcon color='secondary' icon='print' className='me-3' /> 0914 911 577
              </p>
            </MDBCol>

            <MDBCol className=' mb-12'>
           <div className="mappar">
             <iframe className="maprouter" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3834.2417671117073!2d108.20806877589212!3d16.05293913987231!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3142195a60ca3229%3A0x14d418bcb191412d!2sKCL%20Solutions!5e0!3m2!1svi!2s!4v1717903294963!5m2!1svi!2s"
              allowFullScreen loading="lazy" 
                       referrerPolicy="no-referrer-when-downgrade" />
           </div>
           
            </MDBCol>

       
          </MDBRow>
        </MDBContainer>
      </section>

      <div className='text-center p-4' style={{ backgroundColor: 'rgba(0, 0, 0, 0.05)' }}>
      Copyright © :
        <a className='text-reset fw-bold' href='https://kclgroup.com/'>
         KCL Group
        </a>
      </div>
    </MDBFooter>
  );
}

export default Footer;
