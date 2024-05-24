// import React from "react";

import React, { useState, useEffect } from 'react';


function Contact() {

    const [data, getdata ] = useState();
    useEffect(() => {
        userdata();
    }, []);
        
 return (

<div className="contact">
    <div className="container">
        <div className="row align-items-center my-5">
            
        <table>
  <tr>
    <th>name</th>
    <th>password</th>
    <th>id</th>
    <th>edit</th>
  </tr>
    { data && data.map((user) => (   
      <tr key={user.id}>
        <td>{user.name}</td>        
        <td>{user.password}</td>
        <td>{user.id}</td>
        <td><button onClick={delele(user.id)}>delete</button></td>
  </tr>))}
</table>
    </div>
</div>
</div>      
 );

 async function userdata() {
    const response = await fetch('https://65b87570b71048505a88a94e.mockapi.io/est');
    const data = await response.json();
    getdata(data);
}

function delele(id) {
    const handleDelete = async (id) => {    
        try {
            await fetch(`https://65b87570b71048505a88a94e.mockapi.io/est/${id}`, {
                method: 'DELETE'
            });
            setData(data.filter((user) => user.id !== id));
}
catch{
    console.error('Error deleting user:', error);
}
    }

}
}




export default Contact;
