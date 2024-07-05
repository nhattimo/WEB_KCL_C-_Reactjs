import React from 'react';
import Card from 'react-bootstrap/Card';
import "./abcard.css"

  
const HomeCard = (props) => {
  return (
      <Card className="custom3-card">
        <Card.Img variant="top" src={props.img} />
        <Card.Body>
          <Card.Title>
            <a href={props.link}>{props.title}</a>
            </Card.Title>
        </Card.Body>
        <Card.Footer>
          <small className="text-muted">{props.footer}</small>
        </Card.Footer>
      </Card>
  );
};

export default HomeCard;
