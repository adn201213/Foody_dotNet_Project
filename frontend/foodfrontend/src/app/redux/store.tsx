import { configureStore } from '@reduxjs/toolkit'
import counterReducer from '../features/counter/counterSlice'
import { modeReducer } from '../features/product/ModeSlice'
import { productReducer } from '../features/product/ProductSlice'

export default configureStore({
  reducer: {
    counter: counterReducer,
    product:productReducer,
    mode:modeReducer



  }
})