import React, { useEffect } from "react";
import { useParams } from "react-router";

function  K_TECHNICAL() {
  let { postSlug } = useParams();

  useEffect(() => {
    // Fetch post using the postSlug
  }, [postSlug]);

  return (
    <>
    <Banner img={a3} title="K_HEALTHTECH" />
    <AboutItem />  
   <div className="br-1">
       <div className="container mt-5 br-1" >
 
           <div className="row align-items-center ">
             <div className="col-lg-6">
               
               <div  className="parallelogram" >
                 <img
                   className="img-fluid rounded mb-4 mb-lg-0"
                   src="http://placehold.it/900x400"
                   alt=""
                 />
               </div>
             </div>
             <div className="col-lg-6">
               <h1 className="font-weight-light">K_SoLution</h1>
               <p>
                 Lorem Ipsum is simply dummy text of the printing and typesetting
                 industry. Lorem Ipsum has been the industry's standard dummy
                 text ever since the 1500s, when an unknown printer took a galley
                 of type and scrambled it to make a type specimen book.
               </p>
             </div>
           </div>
         
       </div>
       </div>
       </>
  );
}

export default  K_TECHNICAL;
