import { Component, OnInit } from '@angular/core';
@Component({
  templateUrl: './page.html',
  styleUrls: ['./page.less']
})
export class PageComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  title = 'app';

  columnDefs = [
      {headerName: 'Make', field: 'make' },
      {headerName: 'Model', field: 'model' },
      {headerName: 'Price', field: 'price'}
  ];

  rowData = [
      { make: 'Toyota', model: 'Celica', price: 35000 },
      { make: 'Ford', model: 'Mondeo', price: 32000 },
      { make: 'Porsche', model: 'Boxter', price: 72000 }
  ];
}
