import { Address } from "./address";
import { RestaurantType } from "./restaurant-type";

export interface Restaurant {
    id: number;
    name: string;
    score: number;
    phone: string;
    imageUrl: string;
    resume: string;
    createdAt: Date;
    isOpen: boolean;
    federalDocument: string;
    type: RestaurantType;
    address: Address;
}