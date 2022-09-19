import { count } from "console";
import { useDispatch, useSelector } from "react-redux";
import { decrement, increment, incrementByAmount } from "./counterSlice";




export function Counter(){
  const count = useSelector((state:any )=> state.counter.value)
  const dispatch = useDispatch()

return(
  <div>
  <div>
    <button
      aria-label="Increment value"
      onClick={() => dispatch(increment())}
    >
      Increment
    </button>
    <span>{count}</span>
    <button
      aria-label="Decrement value"
      onClick={() => dispatch(decrement())}
    >
      Decrement
    </button>

    <button
      aria-label="Decrement value"
      onClick={() => dispatch(incrementByAmount(7))}
    >
      Decrement
    </button>
  </div>
</div>



)



}

function dispatch(arg0: any): void {
  throw new Error("Function not implemented.");
}
