import { CssBaseline, Typography } from "@mui/material";
import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import Login from "../features/account/Login";
import { Counter } from "../features/counter/Counter";
import ProducsPage from "../features/product/ProducsPage";
import ProductForm from "../features/product/ProductForm";
import ProductGrid from "../features/product/ProductGrid";
import { add } from "../features/product/ProductSlice";
import Header from "./Header";


function App() {
  const mode1=useSelector((state:any)=>state.mode.edit);
  return (
    < >
<CssBaseline/>
<Login/>
<Counter/>
 <Header/> 

{!mode1? <ProducsPage/>:<ProductForm/>}
 
 

 
    </>
  );
}

export default App;
