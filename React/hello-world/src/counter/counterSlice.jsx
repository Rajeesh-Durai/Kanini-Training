import { createSlice } from '@reduxjs/toolkit'
import { Provider } from 'react-redux'
const CounterSlice = createSlice({
  name: 'counter',
  initialState: 0,
  reducer: {
    increment: (state) => state + 1,
    decrement: (state) => state - 1,
  },
})
export const { increment, decrement } = CounterSlice.actions
export default CounterSlice.reducer
