import { Component, OnInit } from '@angular/core';
import { HttpService } from 'service/http.service'

@Component({
  selector: 'page-table',
  templateUrl: './templates.html',
  styleUrls: ['./style.less']
})
export default class implements OnInit {

  constructor(private Http: HttpService) { }

  ngOnInit() {
  }

}
