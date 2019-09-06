import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { ComponentModule } from '../../component';
import { PageComponent } from './page.component';
import ActionComponent from './views/action';
import SearchComponent from './views/search';
import TableComponent from './views/table';
import FormsComponent from './views/forms';
const Components = [
  PageComponent,
  ActionComponent,
  SearchComponent,
  TableComponent,
  FormsComponent
]
@NgModule({
  imports: [
    RouterModule.forChild([
      { path: '', component: PageComponent },
    ]),
    ComponentModule
  ],
  // entryComponents: Components,
  declarations: Components
})
export default class {

}

