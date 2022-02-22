import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastController } from '@ionic/angular';
import { Observable } from 'rxjs';
import { Dish } from '../models/dish.type';
import { ResponseObject } from '../models/response-object';
import { StorageService } from './storage.service';

@Injectable({
  providedIn: 'root'
})
export class DishService {
  private token: string;
  private baseUrl: string = "https://localhost:44397/dish";


  constructor(
    private readonly httpClient: HttpClient,
    private readonly storage: StorageService,
    private readonly toastController: ToastController
  ) {
    this.getToken()
  }

  private setHeaders() {
    return new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${this.token}`
    })
  }
  
  private async getToken() {
    this.token = await this.storage.get('ACCESS_TOKEN');
  }

  async showMessage(message: string) {
    const toast = await this.toastController.create({message, duration: 3000});
    toast.present();
  }

  findDishByRestaurantId(id: number) : Observable<ResponseObject<Dish[]>> {
    return this.httpClient.get<ResponseObject<Dish[]>>(`${this.baseUrl}/restaurant/${id}`, {headers: this.setHeaders()})
  }
}