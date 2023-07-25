import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-qn3',
  templateUrl: './qn3.component.html',
  styleUrls: ['./qn3.component.css'],
})
export class Qn3Component {
  loanAmt = new FormGroup({
    purchaseAmt: new FormControl(''),
    downAmt: new FormControl(''),
    intRate: new FormControl(''),
    timeMon: new FormControl(''),
  });
  intPer!: any;
  intPerAmt!: any;
  calculate() {
    const totalAmt: any = this.loanAmt.value.purchaseAmt;
    const dAmt: any = this.loanAmt.value.downAmt;
    const time: any = this.loanAmt.value.timeMon;
    const rate: any = this.loanAmt.value.intRate;

    const princAmt = totalAmt - dAmt;
    const intAmt = (princAmt * time * rate) / 100;
    this.intPer = intAmt + princAmt;
    this.intPerAmt = this.intPer / 12;
  }
}
