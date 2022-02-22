import { Injectable } from '@angular/core';
import { Storage } from '@ionic/storage';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  private _storage: Storage | null = null

  constructor(private readonly storage: Storage) { 
    this.init()
  }
  
  async init() {
    this._storage = await this.storage.create()
    await this.set("BASE_URL", "https://localhost:44397")
  }

  async set(key: string, value: any) {
    await this._storage?.set(key, value)
  }

  async get(key: string): Promise<any> {
    return await this._storage?.get(key)
  }

  async remove(key: string): Promise<any> {
    return await this._storage?.remove(key)
  }
}
