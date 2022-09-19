import { Button, Card, CardActions, CardContent, CardMedia, Typography } from "@mui/material";
import { useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { ModeSlice } from "./ModeSlice";


const ProductCard=(prop:any)=>{
  const [edit,setEdit]=useState(true);
const dispatch=useDispatch();
const mode1=useSelector((state:any)=>state.mode);
  return(   
  <Card sx={{ maxWidth: 345 }}>
   
   <CardContent>
      <Typography gutterBottom variant="h5" component="div">
      {prop.data.name}
      
      </Typography>
      <Typography variant="body2" color="text.secondary">
      {prop.data.description}
      </Typography>
    </CardContent>
    <CardMedia
      component="img"
      alt="green iguana"
      height="140"
      
      image={prop.data.imageUrl}
    />
    <CardContent>
      <Typography gutterBottom variant="h5" component="div">
      
      </Typography>
      <Typography variant="body2" color="text.secondary">
      {prop.data.Description}
      </Typography>
    </CardContent>
    <CardActions>
      <Button size="small">Add To Cart</Button>
      <Button  size="small">View</Button>
    </CardActions>
  </Card>)
}
export default ProductCard;
