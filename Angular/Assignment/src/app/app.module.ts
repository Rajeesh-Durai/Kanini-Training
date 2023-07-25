import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Qn1Component } from './qn1/qn1.component';
import { Qn2Component } from './qn2/qn2.component';
import { Qn3Component } from './qn3/qn3.component';

@NgModule({
  declarations: [AppComponent, Qn1Component, Qn2Component, Qn3Component],
  imports: [BrowserModule, AppRoutingModule, FormsModule, ReactiveFormsModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
