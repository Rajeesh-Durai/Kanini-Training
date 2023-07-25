import { configureStore } from '@reduxjs/toolkit'
import { CounterReducer } from './counterSlice'
import { Provider } from 'react-redux'
const CounterReducer = configureStore({
  reducer: {
    counter: CounterReducer,
  },
})
export default CounterReducer
