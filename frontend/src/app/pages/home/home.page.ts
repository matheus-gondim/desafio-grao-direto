import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Restaurant } from 'src/app/models/restaurants';
import { User } from 'src/app/models/user';
import { AuthService } from 'src/app/services/auth.service';
import { RestaurantService } from 'src/app/services/restaurant.service';
import { StorageService } from 'src/app/services/storage.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.page.html',
  styleUrls: ['./home.page.scss'],
})
export class HomePage implements OnInit {
  toolBarTitle: string;
  user: User;
  searchbar: boolean = false
  restaurants: Restaurant[] = []
  searchInput: string = ""
  
  constructor(
    private readonly storage: StorageService,
    private readonly authService: AuthService,
    private readonly restaurantService: RestaurantService,
  ) { }
  
  async ngOnInit() {
    this.user = await this.storage.get('USER');
    this.toolBarTitle = this.user?.name ?? "Grain Restaurants";
    this.findRestaurants()
  }

  findRestaurants() {
    this.restaurantService.findRestaurants(this.searchInput)
    .subscribe(
      (value) => {
        this.restaurantService.showMessage(value.message);
        this.restaurants = value.content.items;
        this.searchInput = "";
        this.searchbar = false;
      },
      ({error}) => {
        this.restaurantService.showMessage(error.Messages[0]);
      }
    )
  }
  
  showSearchbar() {
    this.searchbar = !this.searchbar
  }

  logout() {
    this.authService.logout()
  }
}
