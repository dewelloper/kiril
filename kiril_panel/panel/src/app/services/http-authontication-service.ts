﻿import { Injectable } from "@angular/core";
import { Http, Headers } from "@angular/http";
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map'; // (1)

@Injectable()
export class HttpAuthenticationService {

    constructor(private http: Http) { }

    createAuthorizationHeader(headers: Headers) {
        var acct = document['_accessToken'] as string;
        //headers.append('Content-Type', 'application/json');
        //headers.append('Access-Control-Allow-Origin','*');
        //headers.append('Access-Control-Allow-Methods','GET, POST, PATCH, PUT, DELETE, OPTIONS');
        //headers.append('Access-Control-Allow-Headers','Origin, Content-Type, X-Auth-Token');
        headers.append('dataType', 'jsonp');
        headers.append('Authorization', 'Bearer ' + acct);
    }

    getApiAccount(): Observable<any> {
        var url = 'http://beta.core.markum.net/api/CustomerAccount';
        let headers = new Headers();
        this.createAuthorizationHeader(headers);
        return this.http.get(url, {
            headers: headers
        }).map(res => res.json());


    }
}