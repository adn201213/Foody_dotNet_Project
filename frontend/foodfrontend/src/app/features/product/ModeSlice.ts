import { createSlice } from "@reduxjs/toolkit";



export const ModeSlice=createSlice({
  name:'mode',
initialState:{
edit:false,

},
reducers:{
  update:(state:any,action:any)=>{state.edit=action.payload;console.log("state",state.edit)}



}})

export const {update}=ModeSlice.actions;
export const modeReducer=ModeSlice.reducer;
