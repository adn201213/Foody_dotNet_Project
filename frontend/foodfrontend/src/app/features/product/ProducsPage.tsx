import { useEffect, useState } from "react";
import agent from "../../api/agent";
import ProductGrid from "./ProductGrid"
import { useParams } from "react-router";
import ProductForm from "./ProductForm";
import { useSelector } from "react-redux";
const ProducsPage=()=>{


  const {id}=useParams<{id: string}>();

  const [Products,setProducts]=useState([]);
  const mode1=useSelector((state:any)=>state.mode.edit);
  useEffect(()=>{

agent.Product.list().then(data=>setProducts(data));

  },[])
  console.log(Products);
  console.log("HEL");
  console.log("main page",mode1);
return(
  <ProductGrid products={Products}/>
)
}
export default ProducsPage;