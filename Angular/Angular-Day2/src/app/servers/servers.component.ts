import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css'],
})
export class ServersComponent {
  serverCreateOptions: boolean = false;
  serverList = ['S1', 'S2', 'S3', 'S4', ''];
  num: number = 0;
  serverSelected: string = '';

  constructor() {
    let times: number = 500;
  }
}
