import React from "react";

const Contencard = ({ index, name, title, img }) => {
  return (
    <div className={`container-fluid  ${index % 2 === 0 ? 'bg-2' : 'bg-1'}`}>
      <div className={`container `}>
        <div className="row p-3" >
          <div className={`col-lg-6 ${index % 2 === 0 ? 'order-lg-2' : ''}`}>
            <h1 className="font-weight-light">{name}</h1>
            <p>{title}</p>
            <a href={props.link} className="btn btn-orange">Xem thêm</a>
          </div>
          <div className="col-lg-6">
            <img
              className="img-fluid rounded mb-4 mb-lg-0"
              src={img}
              alt=""
            />
          </div>
        </div>
      </div>
    </div>
  );
}

export default Contencard;
