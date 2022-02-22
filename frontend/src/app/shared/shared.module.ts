import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ErrorMessageComponent } from './components/error-message/error-message.component';
import { IonicModule } from '@ionic/angular';
import { MatExpansionModule } from '@angular/material/expansion'
import { DishCardComponent } from './components/dish-card/dish-card.component';


@NgModule({
  declarations: [
    ErrorMessageComponent, 
    DishCardComponent,
  ],
  imports: [
    CommonModule,
    IonicModule,
    MatExpansionModule
  ],
  exports:[
    ErrorMessageComponent, 
    DishCardComponent,
  ]
})
export class SharedModule { }
