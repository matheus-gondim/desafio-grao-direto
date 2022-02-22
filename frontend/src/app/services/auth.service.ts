import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastController } from '@ionic/angular';
import { BehaviorSubject, Observable } from 'rxjs';
import { ResponseObject } from '../models/response-object';
import { SignIn } from '../models/sign-in';
import { SignUp } from '../models/sign-up';
import { UserAndTokenResponse } from '../models/user-and-token-response';
import { StorageService } from './storage.service';
import { tap } from 'rxjs/operators';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  baseUrl: string;
  authSubject  =  new  BehaviorSubject(false);

  constructor(
    private readonly toastController: ToastController,  
    private readonly httpClient: HttpClient,
    private  storage:  StorageService,
    private readonly router: Router,
  ) { 
    this.getBaseUrl()
  }


  private async getBaseUrl() {
    const url: string = await this.storage.get("BASE_URL");
    this.baseUrl = url + "/auth";
  }

  async showMessage(message: string) {
    const toast = await this.toastController.create({message,duration: 3000});
    toast.present();
  } 

  signUp(signUp: SignUp): Observable<ResponseObject<UserAndTokenResponse>> {
    return this.httpClient
    .post<ResponseObject<UserAndTokenResponse>>(this.baseUrl+"/sign-up", signUp)
    .pipe(tap(async (res) => {
        if(res.content) this.setDataInStorage(res)
      })
    )
  }

  signIn(signIn: SignIn): Observable<ResponseObject<UserAndTokenResponse>> {
    return this.httpClient
    .post<ResponseObject<UserAndTokenResponse>>(this.baseUrl+"/sign-in", signIn)
    .pipe(tap(async (res: any) => {
      if(res.content) this.setDataInStorage(res)
    }))
  }

  logout() {
    this.storage.remove("ACCESS_TOKEN").then(() => {
      this.router.navigate(['/login'])
    })
  }

  private async setDataInStorage(res: ResponseObject<UserAndTokenResponse>) {
    await this.storage.set("ACCESS_TOKEN", res.content.accessToken)
    await this.storage.set("USER", res.content.user)
    this.authSubject.next(true);
  }

}
