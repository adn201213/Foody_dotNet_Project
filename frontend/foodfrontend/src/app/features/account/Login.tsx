import * as React from 'react';
import Avatar from '@mui/material/Avatar';
import Button from '@mui/material/Button';
import CssBaseline from '@mui/material/CssBaseline';
import TextField from '@mui/material/TextField';
import FormControlLabel from '@mui/material/FormControlLabel';
import Checkbox from '@mui/material/Checkbox';
import Link from '@mui/material/Link';
import Grid from '@mui/material/Grid';
import Box from '@mui/material/Box';
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import { createTheme, ThemeProvider } from '@mui/material/styles';
import { FieldValues, SubmitHandler, useForm } from "react-hook-form";
import agent from '../../api/agent';
import { LoadingButton } from '@mui/lab';

type Inputs = {
  UserName: string,
  password: string,
}

const theme = createTheme();

export default function Login() {


  const { register, handleSubmit, watch, formState: { isSubmitting,errors,isValid } } = useForm<Inputs>(

{
mode:'onBlur'

}

  );
  const submitForm = async (data:FieldValues) =>
   { console.log("data",data);
   await agent.Account.login(data).then(data=>
    console.log(data))};

   
  // const handleSubmit = (event: React.FormEvent<HTMLFormElement>) => {
  //   event.preventDefault();
  //   const data = new FormData(event.currentTarget);
  //   console.log({
  //     email: data.get('email'),
  //     password: data.get('password'),
  //   });
  // };

  return (
    <ThemeProvider theme={theme}>
      <Container component="main" maxWidth="xs">
        <CssBaseline />
        <Box
          sx={{
            marginTop: 8,
            display: 'flex',
            flexDirection: 'column',
            alignItems: 'center',
          }}
        >
          <Avatar sx={{ m: 1, bgcolor: 'secondary.main' }}>
            <LockOutlinedIcon />
          </Avatar>
          <Typography component="h1" variant="h5">
            Sign in
          </Typography>
          <Box component="form" onSubmit={handleSubmit(submitForm)} noValidate sx={{ mt: 1 }}>
 
            <TextField
              margin="normal"
              required
              fullWidth
              id="UserName"
              label="Email Address"
            
              autoComplete="email"
              autoFocus
              {...register("UserName", { required: "UserName is required" })}
              error={!!errors.UserName}
              helperText={errors?.UserName?.message}
            />
            {/* {errors.UserName && <span style={{color:"red"}}>This field is required</span>} */}
            <TextField
              margin="normal"
              required
              fullWidth
           
              label="Password"
              type="password"
              id="password"
              autoComplete="current-password"
              {...register("password", { required: "Password is required" })}
              error={!!errors.password}
              helperText={errors?.password?.message}
             
            />
             {/* {errors.password && <span style={{color:"red"}}>This field is required</span>} */}
            {/* {errors.password && <span>This field is required</span>}
            <FormControlLabel
              control={<Checkbox value="remember" color="primary" />}
              label="Remember me"
            /> */}
            <LoadingButton loading={isSubmitting}
            disabled={!isValid}
              type="submit"
              fullWidth
              variant="contained"
              sx={{ mt: 3, mb: 2 }}
            >
              Sign In
            </LoadingButton>
            {/* <Grid container>
              <Grid item xs>
                <Link href="#" variant="body2">
                  Forgot password?
                </Link>
              </Grid>
              <Grid item>
                <Link href="#" variant="body2">
                  {"Don't have an account? Sign Up"}
                </Link>
              </Grid>
            </Grid> */}
          </Box>
        </Box>
   
      </Container>
    </ThemeProvider>
  );
}