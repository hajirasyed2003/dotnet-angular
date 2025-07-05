import { Routes } from '@angular/router';

import { TemplateDrivenRegistration } from './template-driven-registration/template-driven-registration';
import { ReactiveRegistration } from './reactive-registration/reactive-registration';

export const routes: Routes = [
  { path: 'template-form', component: TemplateDrivenRegistration },
  { path: 'reactive-form', component: ReactiveRegistration },
  { path: '', redirectTo: 'reactive-form', pathMatch: 'full' }
];
