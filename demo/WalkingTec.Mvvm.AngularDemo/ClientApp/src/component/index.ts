import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AgGridModule } from 'ag-grid-angular';
import { NgZorroAntdModule, NZ_I18N, zh_CN } from 'ng-zorro-antd';
import { TableComponent } from './table/table.component';

const Component = [
   TableComponent,
]
@NgModule({
   imports: [
      NgZorroAntdModule,
      AgGridModule.withComponents()
   ],
   declarations: Component,
   exports: [NgZorroAntdModule, ...Component],
   providers: [{ provide: NZ_I18N, useValue: zh_CN }],
})
export class ComponentModule { }
