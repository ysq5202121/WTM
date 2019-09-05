import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: 'welcome', loadChildren: () => import('./welcome/welcome.module').then(m => m.WelcomeModule) },
  { path: 'Monitor', loadChildren: () => import('./test/welcome.module').then(m => m.WelcomeModule) }
];
