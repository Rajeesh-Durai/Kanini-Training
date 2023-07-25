import { useState } from 'react'
import React from 'react'

const UseStateFn = () => {
  const [count, setCount] = useState(0)
  const HandleClick = () => {
    setCount(count + 1)
  }
  return (
    <div>
      <h4>You have clicked {count} times</h4>
      <button type="button" onClick={HandleClick}>
        Click me
      </button>
    </div>
  )

  // const [color, setColor] = useState('Red')
  // const [car, setCar] = useState('Mustang')
  // const [year, setYear] = useState('1967')
  // return (
  //   <div>
  //     <h4>
  //       I have a {color} colored {car} {year} model
  //     </h4>
  //   </div>
  // )
}

export default UseStateFn
