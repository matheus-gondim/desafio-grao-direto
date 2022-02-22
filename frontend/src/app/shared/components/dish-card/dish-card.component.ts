import { Component, Input, OnInit } from '@angular/core';
import { Dish } from 'src/app/models/dish.type';

@Component({
  selector: 'app-dish-card',
  templateUrl: './dish-card.component.html',
  styleUrls: ['./dish-card.component.scss'],
})
export class DishCardComponent implements OnInit {
  @Input() dish: Dish

  constructor() { }

  ngOnInit() {
  }

}
