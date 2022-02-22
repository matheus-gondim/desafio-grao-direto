import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastController } from '@ionic/angular';
import { Observable } from 'rxjs';
import { Page } from '../models/page';
import { ResponseObject } from '../models/response-object';
import { Restaurant } from '../models/restaurants';
import { StorageService } from './storage.service';


@Injectable({
  providedIn: 'root'
})
export class RestaurantService {
  private token: string;
  private baseUrl: string = "https://localhost:44397/restaurant";


  constructor(
    private readonly httpClient: HttpClient,
    private readonly storage: StorageService,
    private readonly toastController: ToastController
  ) {
    this.getToken()
  }
  
  private async getToken() {
    this.token = await this.storage.get('ACCESS_TOKEN');
  }

  private setHeaders() {
    return new HttpHeaders({
      'Content-Type': 'application/json',
      'Authorization': `Bearer ${this.token}`
    })
  }

  async showMessage(message: string) {
    const toast = await this.toastController.create({message,duration: 3000});
    toast.present();
  } 

  findRestaurants(name: string = "") : Observable<ResponseObject<Page<Restaurant>>> {
    const params = new HttpParams().set('name', name);
    return this.httpClient.get<ResponseObject<Page<Restaurant>>>(this.baseUrl, {headers: this.setHeaders(), params})
  }

  findRestaurantById(id: number) : Observable<ResponseObject<Restaurant>> {
    return this.httpClient.get<ResponseObject<Restaurant>>(`${this.baseUrl}/${id}`, {headers: this.setHeaders()})
  }
}
