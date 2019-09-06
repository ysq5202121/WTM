import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AgGridModule } from 'ag-grid-angular';
import { NgZorroAntdModule, NZ_I18N, zh_CN } from 'ng-zorro-antd';
import { TableComponent } from './table/table.component';
import { NzResizableModule } from 'ng-zorro-antd/resizable';
const Component = [
   TableComponent,
]
@NgModule({
   imports: [
      CommonModule,
      ReactiveFormsModule,
      FormsModule,
      NgZorroAntdModule,
      NzResizableModule,
      AgGridModule.withComponents()
   ],
   declarations: Component,
   exports: [
      CommonModule,
      ReactiveFormsModule,
      FormsModule,
      NgZorroAntdModule,
      NzResizableModule,
      ...Component
   ],
   providers: [{ provide: NZ_I18N, useValue: zh_CN }],
})
export class ComponentModule { }
