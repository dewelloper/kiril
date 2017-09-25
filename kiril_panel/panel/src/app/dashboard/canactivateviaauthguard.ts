import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { HttpAuthenticationService } from '../services/http-authontication-service';

@Injectable()
export class CanActivateViaAuthGuard implements CanActivate {

    constructor(private authService: HttpAuthenticationService) { }

    canActivate() {
        return this.authService.getApiAccount();
    }
}