import React from "react";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import "@fortawesome/fontawesome-free/css/all.min.css";
import {
  Slide,
  AboutItem,
  MutiTeam,
  MutiCase,
  MutiProduct,
  TamNhin
} from "../components";

function Home() {
  return (
    <>
    <Slide />
    <TamNhin  />
    <AboutItem />
    <MutiProduct />
    <MutiCase />
    <MutiTeam />
    </>
  );
}

export default Home;
