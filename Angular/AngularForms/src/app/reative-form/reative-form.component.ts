import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ValidateUrl } from './urlValidation';

@Component({
  selector: 'app-reative-form',
  templateUrl: './reative-form.component.html',
  styleUrls: ['./reative-form.component.css'],
})
export class ReativeFormComponent implements OnInit {
  validateForm!: FormGroup;
  constructor(private fb: FormBuilder) {}

  ngOnInit(): void {
    this.validateForm = this.fb.group({
      Pagename: ['', Validators.required],
      myURL: ['', [Validators.required, ValidateUrl]],
    });
  }

  saveForm(form: FormGroup) {
    console.log('Valid', form.valid);
    console.log('PageName', form.value.Pagename);
    console.log('URL', form.value.myURL);
  }

  // contactForm = new FormGroup({
  //   firstname: new FormControl('', [
  //     Validators.required,
  //     Validators.minLength(5),
  //     Validators.pattern('^[a-zA-Z]+$'),
  //   ]),
  //   // firstname: new FormControl("Rahul"),
  //   // firstname: new FormControl({ value: "Rahul", disabled: true} ),

  //   lastname: new FormControl(),
  //   email: new FormControl(),
  //   gender: new FormControl(),
  //   isMarried: new FormControl(),
  //   country: new FormControl(),
  // });
  // get firstname() {
  //   return this.contactForm.get('firstname');
  // }

  // onSubmit() {
  //   console.log('submit');
  //   console.log(this.contactForm.value);
  // }
}
