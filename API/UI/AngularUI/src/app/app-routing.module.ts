import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { RezerwacjaComponent } from './rezerwacja/rezerwacja.component'; 
import { JachtyComponent } from './jachty/jachty.component';
const routes: Routes = [
{path:'rezerwacja',component:RezerwacjaComponent},
{path:'jachty',component:JachtyComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
