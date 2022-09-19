import { createSlice } from "@reduxjs/toolkit";



 export const ProductSlice=createSlice({
name:'product',
initialState:{
  products: []
},
reducers:{
get:(state:any)=>(state),
add:(state:any,action:any)=>{(state.products.push(action.payload))}
//add:(state:any,action:any)=>{console.log("state",{...state});
//return({...state})}



}



});

export const productReducer = ProductSlice.reducer;
export const {
  get,
  add,

} = ProductSlice.actions;