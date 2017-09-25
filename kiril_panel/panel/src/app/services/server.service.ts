﻿import { Injectable } from '@angular/core';
import { Headers, Http, Response } from '@angular/http';

import { Observable } from 'rxjs/Observable';

import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/map'; 
import 'rxjs/add/operator/catch'; 

import { Server } from './../dashboard/server';
//import { SERVERS } from './mock-servers';

@Injectable()
export class ServerService {
    //private serversUrl = 'api/servers';  
    private serversUrl = 'http://beta.core.markum.net/api/VirtualMachine/GetVirtualServerByCustomer'; 
    private detailUrl = 'http://beta.core.markum.net/api/VirtualMachine/GetVirtualServerDetailByServerId?serverId=';    
    private deleteUrl = 'http://beta.core.markum.net/api/VirtualMachine/DeleteVirtualServerByServerId?virtualServerId=';    
    

    private headers = new Headers({ 'Content-Type': 'application/json' });
    private authHeaders = new Headers({ 'Authorization': 'Bearer eAzof_R8atIktBYjVwB6y4A5RGiDIqULWg_w48vcQJ_Xoxrx36NmESR6nWYot6LLDNM0fqoOhiFgxf7osuF82a0k4xEaoz_dT6MH2Yj4zphTZxKazytojuHabINuKLbgOvZYtKCYih0I8FbEa_hFd1AC0CYSJmsg6jv9_9mpLN3Ho6eXaVrO0KRHKZhY9Gt01Ju-Ou1kzJY5W6gw_vgOKbOP2WadGY1k4fJYwlx4fnX9Drqeeb0PDNyLACV7Z8bQTV7XzAZhdA9mo3MM5Z-OKgU1rKz-If_PP_UsnBbOHOGsl3RDcRY0bcsiVAhMCLbPW9IRcB8Y6tOtlHW2C2iqyBgRAj_IBC-Us5bIDMnqiNc' });

    constructor(private http: Http) { }



    createAuthorizationHeader(headers2: Headers) {
        var acct = document['_accessToken'] as string;
        //headers.append('Content-Type', 'application/json');
        //headers.append('Access-Control-Allow-Origin','*');
        //headers.append('Access-Control-Allow-Methods','GET, POST, PATCH, PUT, DELETE, OPTIONS');
        //headers.append('Access-Control-Allow-Headers','Origin, Content-Type, X-Auth-Token');
        headers2.append('dataType', 'jsonp');
        headers2.append('Authorization', 'Bearer ' + acct);
    }

    createAuthorizationHeaderPost(headers2: Headers) {
        var acct = document['_accessToken'] as string;
        headers2.append('Content-Type', 'application/json');
        //headers.append('Access-Control-Allow-Origin','*');
        //headers.append('Access-Control-Allow-Methods','GET, POST, PATCH, PUT, DELETE, OPTIONS');
        //headers.append('Access-Control-Allow-Headers','Origin, Content-Type, X-Auth-Token');
        //headers2.append('dataType', 'jsonp');
        headers2.append('Authorization', 'Bearer ' + acct);
    }

    

    getServers(): Promise<Server[]> {
        let headers2 = new Headers();
        this.createAuthorizationHeader(headers2);

        return this.http.get(this.serversUrl, { headers: headers2 })
            .toPromise()
            .then(response => response.json().data as Server[])
            .catch(this.handleError);
    }

    private extractData(res: Response) {
        let body = res.json();
        return body.data || {};
    }

    getServer(Id: number): Promise<Server> {
        const url = `${this.detailUrl}` + `${Id}`;
        let headers2 = new Headers();
        this.createAuthorizationHeader(headers2);

        return this.http.get(url, { headers: headers2 })
            .toPromise()
            .then(response => response.json().data as Server)
            .catch(this.handleError);
    }

    create(serverType: string, nodeName: string, hostName: string, planName: string, ipCount: number, virtType: string): Promise<Server> {
        var url = 'http://beta.core.markum.net/api/VirtualMachine/Create';
        let headers2 = new Headers();
        this.createAuthorizationHeaderPost(headers2);

        var obj = {
            "Template": serverType,  // "Centos6.7-x64-Minimal",    // "Centos6.7-x64-Minimal",  //
            "NodeName": nodeName,   // "testnode",  //  
            "HostName": hostName,      //"ali12.test.com",    //  
            //"UserName": userName,  //    "ugurkizilkaya",  //  
            //"Password": pass,    //"123456",
            "PlanName": planName,    //   "test_plan",    //  
            "IpCount": ipCount,  // 1,    // 
            "VirtualizationType": virtType   //  "SolusVm"   //  
        }

        return this.http.post(url, JSON.stringify(obj), { headers: headers2})
            .toPromise()
            .then(res => res.json().data as Server)
            .catch(this.handleError);
    }

    delete(virtualServerId: string): Promise<void> {
        const url = `${this.deleteUrl}` + `${virtualServerId}`;
        //const url = `${this.serversUrl}/${virtualServerId}`;

        let headers2 = new Headers();
        this.createAuthorizationHeaderPost(headers2);

        return this.http.delete(url, { headers: headers2 })
            .toPromise()
            .then(() => null)
            .catch(this.handleError);
    }

    delete_(virtualServerId: string): Observable<any> {
        const url = `${this.deleteUrl}` + `${virtualServerId}`;
        //const url = `${this.serversUrl}/${virtualServerId}`;

        let headers2 = new Headers();
        this.createAuthorizationHeaderPost(headers2);

        return this.http.delete(url, { headers: headers2 })
            .map(this.extractData)            
            .catch(this.handleError);
    }

    getServers_(): Observable<any> {
        //var url = 'http://beta.core.markum.net/api/customeraccount';
        let headers2 = new Headers();
        this.createAuthorizationHeader(headers2);

        return this.http.get(this.serversUrl, { headers: headers2 })
            .map(this.extractData)
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('Bir hata oluştu', error);
        return Promise.reject(error.message || error);
    }

    
    /////////////////////***************  From separate project **********/////////////////////

    getServers__(): Promise<Server[]> {        
        return this.http.get(this.serversUrl) //, { headers: this.authHeaders })
            .toPromise()
            .then(response => response.json().data as Server[])
            .catch(this.handleError);
    }    

    getServersSlowly(): Promise<Server[]> {
        return new Promise(resolve => {
            setTimeout(() => resolve(this.getServers()), 2000);
        });
    }    

    update(server: Server): Promise<Server> {
        const url = `${this.serversUrl}/${server.Id}`;
        return this.http.put(url, JSON.stringify(server), { headers: this.headers })
            .toPromise()
            .then(() => server)
            .catch(this.handleError);
    }

    create_(name: string): Promise<Server> {
        return this.http.post(this.serversUrl, JSON.stringify({ name: name }), { headers: this.headers })
            .toPromise()
            .then(res => res.json().data as Server)
            .catch(this.handleError);
    }    
}