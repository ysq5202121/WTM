import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: 'welcome', loadChildren: () => import('./welcome/page.module').then(x => x.default) },
  { path: 'Monitor', loadChildren: () => import('./test/page.module').then(x => x.default) }
];
