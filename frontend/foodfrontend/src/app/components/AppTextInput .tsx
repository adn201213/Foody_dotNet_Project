import { TextField } from "@mui/material"
import { useController, UseControllerProps } from "react-hook-form"

interface Props extends UseControllerProps{
  label:string;
  multiline?:boolean;
rows?:number,
type?:string
}

const AppTextInput=(props:Props)=>{
const{field,fieldState}=useController({...props,defaultValue:''});
return(
  <TextField
 {...field}
 {...props}
 multiline={props.multiline}
 rows={props.rows}
 type={props.type}
 fullWidth
 variant='outlined'
 error={!!fieldState.error}
 helperText={fieldState.error?.message}
/>



)



}

export default AppTextInput;