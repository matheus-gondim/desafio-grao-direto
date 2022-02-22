import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Dish } from 'src/app/models/dish.type';
import { Restaurant } from 'src/app/models/restaurants';
import { User } from 'src/app/models/user';
import { DishService } from 'src/app/services/dish.service';
import { RestaurantService } from 'src/app/services/restaurant.service';
import { StorageService } from 'src/app/services/storage.service';

@Component({
  selector: 'app-restaurant',
  templateUrl: './restaurant.page.html',
  styleUrls: ['./restaurant.page.scss'],
})
export class RestaurantPage implements OnInit {
  id: string
  dishes: Dish[] = []
  user: User;
  restaurant: Restaurant;

  constructor(
    private readonly route: ActivatedRoute,
    private readonly location: Location,
    private readonly restaurantService: RestaurantService,
    private readonly dishService: DishService,
    private readonly storage: StorageService,
  ) { }

  async ngOnInit() {
    this.id = this.route.snapshot.paramMap.get('id')
    this.user = await this.storage.get('USER');
    this.findRestaurants()
    this.findDishesByRestaurantId()
  }

  toBackPage() {
    this.location.back()
  }

  findRestaurants() {
    this.restaurantService.findRestaurantById(parseInt(this.id))
    .subscribe(
      (value) => {
        this.restaurantService.showMessage(value.message);
        this.restaurant = value.content;
      },
      ({error}) => {
        this.restaurantService.showMessage(error?.Messages[0]?? error);
      }
    )
  }
    
  findDishesByRestaurantId() {
    this.dishService.findDishByRestaurantId(parseInt(this.id))
    .subscribe(
      (value) => {
        this.restaurantService.showMessage(value.message);
        this.dishes = value.content
      },
      ({error}) => {
        this.restaurantService.showMessage(error?.Messages[0]?? error);
      }
    )
  }
}
