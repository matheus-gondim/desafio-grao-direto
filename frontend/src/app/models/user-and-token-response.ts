import { User } from "./user";

export interface UserAndTokenResponse {
    accessToken: string,
    refreshToken: string,
    user: User,
    expiration: Date,
    created: Date,
}