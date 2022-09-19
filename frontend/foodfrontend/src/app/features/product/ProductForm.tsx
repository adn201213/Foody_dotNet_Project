import { Box, Button, Grid, Paper, TextField, Typography } from "@mui/material";
import { red } from "@mui/material/colors";
import { FieldValues, useForm } from "react-hook-form";
import LoadingButton from '@mui/lab/LoadingButton';
import type {} from '@mui/lab/themeAugmentation';
import AppTextInput from "../../components/AppTextInput ";
import agent from "../../api/agent";
import { useDispatch, useSelector } from "react-redux";
import { add, ProductSlice } from "./ProductSlice";
import {update}from "./ModeSlice";
const ProductForm=()=>{
    const dispatch = useDispatch();
const {register,control,handleSubmit,formState:{isSubmitting}}=useForm();
const submitForm=(data:any)=>{
    dispatch(ProductSlice.actions.add(data));
    console.log("my data",data)
    agent.Product.create(data);
}
const p=useSelector((state:any)=>state.product);
const mode1=useSelector((state:any)=>state.mode.edit);
console.log("ppp",p)
return(
  <Box component={Paper} sx={{ p: 4}}>

<Typography variant="h4" gutterBottom sx={{ mb: 4 }}>
                Product Details
            </Typography>
<form  onSubmit={handleSubmit(submitForm)}>

<Grid container spacing={3}> 
<Grid item xs={12} sm={12}>
                        <AppTextInput control={control} name='name' label='Product name' />
              
                   
                   
                    </Grid>

                    <Grid item xs={12} sm={6}>
                        <AppTextInput control={control} name='type' label='type' />
              
                   
                   
                    </Grid>   
                    <Grid item xs={12} sm={6}>
                        <AppTextInput control={control} name='price' label='price' />
              
                   
                   
                    </Grid>  
                    
                    <Grid item xs={12} sm={6}>
                        <AppTextInput control={control} name='availabilty' label='availabilty' />
              
                   
                   
                    </Grid>   
                    <Grid item xs={12} sm={6}>
                        <AppTextInput control={control} name='cuisine' label='cuisine' />
              
                   
                   
                    </Grid> 
                    <Grid item xs={12}>
                        <AppTextInput multiline={true} rows={4} control={control} name='Description' label='Description' />
                    </Grid>

</Grid>



     <Box display='flex'  sx={{ mt: 3 }}>
                     <Button onClick={()=>{dispatch(update(!mode1)); }} sx={{ mr: 3 }} variant='contained' color='inherit'>Cancel</Button> 
                    <LoadingButton loading={isSubmitting} type='submit' variant='contained' color='success'>Submit</LoadingButton>

                    
                </Box>
             





</form>

    
  </Box>

 





)





}


export default ProductForm;