import React from "react";
import "./Home.css";
import {
  Slide,
  AboutItem,
  MutiTeam,
  TopNews,
  MutiProduct,
  TamNhin,
  IntroAbout  
} from "../components";

function Home() {
  return (
    <>
    <Slide />
    <TamNhin  />
    <IntroAbout  /> 
    <TopNews />
    <AboutItem />
    <MutiProduct />
    <MutiTeam />
    </>
  );
}

export default Home;
