import { NgModule } from '@angular/core';
import { ComponentModule } from '../../component';
import { PageComponent } from './page.component';
import { Routes, RouterModule } from '@angular/router';
@NgModule({
  imports: [
    RouterModule.forChild([
      { path: '', component: PageComponent },
    ]),
    ComponentModule
  ],
  declarations: [PageComponent]
})
export default class {

}

