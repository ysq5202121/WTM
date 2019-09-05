import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ComponentModule } from '../../component';
import { PageComponent } from './page.component';
import { TesttComponent } from './testt/testt.component';
@NgModule({
  imports: [
    RouterModule.forChild([
      { path: '', component: PageComponent },
    ]),
    ComponentModule
  ],
  declarations: [PageComponent, TesttComponent]
})
export default class {

}

