import { NgModule } from '@angular/core';

import { WelcomeRoutingModule } from './welcome-routing.module';

import { WelcomeComponent } from './welcome.component';
import { AgGridModule } from 'ag-grid-angular';


@NgModule({
  imports: [WelcomeRoutingModule, AgGridModule.withComponents()],
  declarations: [WelcomeComponent],
  exports: [WelcomeComponent]
})
export class WelcomeModule {

}
