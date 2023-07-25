import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-qn2',
  templateUrl: './qn2.component.html',
  styleUrls: ['./qn2.component.css'],
})
export class Qn2Component {
  urlForm = new FormGroup({
    urlName: new FormControl(''),
  });

  output!: any;

  shorten(): void {
    const shortUrl = this.urlForm.value.urlName;
    console.log(shortUrl);
    this.output = UrlValid(shortUrl);
  }
  copyFn() {
    navigator.clipboard.writeText(this.output); //copying the url
    alert('The link is copied!!');
  }
}
function UrlValid(shortUrl: any): any {
  const short: string = shortUrl.split('/', 1);
  console.log(short);
  return short;
}
