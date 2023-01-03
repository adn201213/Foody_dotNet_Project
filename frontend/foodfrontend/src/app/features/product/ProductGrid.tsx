import { Button, Grid } from "@mui/material";
import { useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { ModeSlice } from "./ModeSlice";
import Productcard from "./Productcard";
import {update}from "./ModeSlice";

const ProductGrid=(prop:any)=>{
  const dispatch=useDispatch();
  const mode1=useSelector((state:any)=>state.mode.edit);

  const[mode,setMode]=useState(false);

  return (
<>
<Button onClick={()=>{dispatch(update(!mode1)); }} sx={{float:"right",margin:10}} variant="contained">Create Product</Button>
      <Grid container spacing={4} sx={{margin:5}}>
        {prop.products.map((p: any)=>(
        <Grid  key={p.id} item xs={3}>
        <Productcard data={p} key={p.id}/>
      </Grid>
        ) )}
      </Grid>
      </>
  );

}

export default ProductGrid;