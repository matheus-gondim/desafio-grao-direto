import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Restaurant } from 'src/app/models/restaurants';

@Component({
  selector: 'app-restaurant-card',
  templateUrl: './restaurant-card.component.html',
  styleUrls: ['./restaurant-card.component.scss'],
})
export class RestaurantCardComponent implements OnInit {
  @Input() restaurant: Restaurant
  
  constructor(private readonly router: Router) { }

  ngOnInit() {
  }

  toDishPage() {
    this.router.navigate([`/restaurant`, this.restaurant.id])
  }

}
