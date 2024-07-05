import React from 'react';
import Card from 'react-bootstrap/Card';
import "./abcard.css"

  
const CustomCard = (props) => {
  return (
      <Card className="custom2-card">
        <Card.Img variant="top" src={props.img} />
        <Card.Body>
          <Card.Title>{props.title}</Card.Title>
          <Card.Text>
            {props.subtitle}
          </Card.Text>
          <a href={props.link} className="btn btn-orange">Xem thêm</a>
        </Card.Body>
        <Card.Footer>
          <small className="text-muted">{props.footer}</small>
        </Card.Footer>
      </Card>
  );
};



export default CustomCard;
