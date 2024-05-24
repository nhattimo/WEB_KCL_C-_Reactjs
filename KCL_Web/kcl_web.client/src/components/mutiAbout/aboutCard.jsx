import React, { Component } from 'react';

function AboutCard(props) {
    return (
        <div className="col-lg-4 col-md-6 mb-5">
        <div className="card h-100">
        <div className="card-body">
        <h4 className="card-title">
        <a href="#">
        {props.title}
        </a>
        </h4>
        <h6 className="card-subtitle mb-2 text-muted">
            {props.subtitle}

            </h6>
            <p className="card-text">
                {props.text}
                </p>
                </div>
                <div className="card-footer text-muted">
                    {props.footer}
                    </div>
                    </div>
                    </div>
    )}

    export default AboutCard;