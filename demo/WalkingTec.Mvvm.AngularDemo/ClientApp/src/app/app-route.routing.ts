import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { routes } from '../pages';
@NgModule({
  imports: [RouterModule.forRoot([
    { path: '', pathMatch: 'full', redirectTo: '/welcome' },
    ...routes
  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
