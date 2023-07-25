import React from 'react'
import { useSelector, useDispatch } from 'react-redux'
import { increment, decrement } from './counterSlice'
import { Provider } from 'react-redux'
const CounterComponent = () => {
  const xxx = useSelector((state) => state.counter)
  const dispatch = useDispatch()
  const incrementCounter = () => {
    dispatch(increment())
  }
  const decrementCounter = () => {
    dispatch(decrement())
  }
  return (
    <div>
      <p>Counter: {xxx}</p>
      <button onClick={incrementCounter}>increment</button>
      <button onClick={decrementCounter}>decrement</button>
    </div>
  )
}

export default CounterComponent
