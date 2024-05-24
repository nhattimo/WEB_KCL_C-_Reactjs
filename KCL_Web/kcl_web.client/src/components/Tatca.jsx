import React from 'react';


function Tatca() {
  return (
    <div className="home">
      <div class="container">
        <h1 className="text-center mt-5">Blog page</h1>
        <Outlet />
      </div>
    </div>
  );
}

export default Tatca;