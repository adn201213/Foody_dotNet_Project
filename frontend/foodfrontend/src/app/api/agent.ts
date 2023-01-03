import axios, { AxiosResponse } from "axios";
axios.defaults.baseURL='http://localhost:5035/api/';
const responseBody=(response:AxiosResponse)=>response.data;

const request={
get:(url:string)=>axios.get(url).then((respons:AxiosResponse)=>respons.data),
post:(url:string,body:{})=>axios.post(url,body).then((respons:AxiosResponse)=>respons.data),
put:(url:string,body:{})=>axios.put(url).then((respons:AxiosResponse)=>respons.data),


}

const Product={
list:()=>request.get('Product'),
details:(id:number)=>request.get(`product/${id}`),
create:(product:any)=>request.post('Product',product),
update:(product:any)=>request.put('product',product),

}
const Account={
  login:(values:any)=>request.post('Account/login',values),
  register:(values:any)=>request.post(`Account/register`,values),
  currentUser:()=>request.get('Account/currentUser'),
  
  }
const agent={
  Product,
Account




}

export default agent;
