import { Component, NgModule, OnInit } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ComponentModule } from 'component';
import { HttpService } from 'service/http.service';
import ActionComponent from './views/action';
import FormsComponent from './views/forms';
import SearchComponent from './views/search';
import TableComponent from './views/table';
@Component({
  template: `
  <page-search></page-search>
  <page-action></page-action>
  <page-table></page-table>
  `,
})
class PageComponent implements OnInit {
  constructor() { }
  ngOnInit() {

  }
}
@NgModule({
  imports: [
    RouterModule.forChild([
      { path: '', component: PageComponent },
    ]),
    ComponentModule
  ],
  providers: [HttpService],
  declarations: [PageComponent, ActionComponent, SearchComponent, TableComponent, FormsComponent]
})
export default class {
  constructor(private HttpService: HttpService) {
    console.log("TCL: constructor -> HttpService", HttpService)
    this.HttpService.onInit({}).onTest()
  }
}
