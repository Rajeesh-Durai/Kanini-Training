import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TempValidation } from './TempValidation';

@Component({
  selector: 'app-qn1',
  templateUrl: './qn1.component.html',
  styleUrls: ['./qn1.component.css'],
})
export class Qn1Component {
  tempForm = new FormGroup({
    initialTemp: new FormControl('', [TempValidation]),
    selectedTemp: new FormControl(''),
  });
  selectedTemp!: string;
  get initialTemp() {
    return this.tempForm?.get('initialTemp');
  }
  temp1!: number;
  output!: number;
  unit!: string;
  handleCheck(): void {
    const selectTemp = this.tempForm.value.selectedTemp;
    if (selectTemp == 'celsius') {
      this.output = fahrenheitFn(this.temp1);
      this.unit = 'fahrenheit';
    }

    if (selectTemp == 'fahrenheit') {
      this.output = celciusFn(this.temp1);
      this.unit = 'celsius';
    }
  }
}
function celciusFn(temp1: number): number {
  const celsius = ((temp1 - 32) * 5) / 9;
  console.log(celsius);
  return celsius;
}
function fahrenheitFn(temp1: number): number {
  const fahrenheit = (temp1 * 9) / 5 + 32;
  return fahrenheit;
}
