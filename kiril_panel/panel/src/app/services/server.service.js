"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var http_1 = require("@angular/http");
require("rxjs/add/operator/toPromise");
require("rxjs/add/operator/map");
require("rxjs/add/operator/catch");
//import { SERVERS } from './mock-servers';
var ServerService = (function () {
    function ServerService(http) {
        this.http = http;
        //private serversUrl = 'api/servers';  
        this.serversUrl = 'http://beta.core.markum.net/api/VirtualMachine/GetVirtualServerByCustomer';
        this.detailUrl = 'http://beta.core.markum.net/api/VirtualMachine/GetVirtualServerDetailByServerId?serverId=';
        this.deleteUrl = 'http://beta.core.markum.net/api/VirtualMachine/DeleteVirtualServerByServerId?virtualServerId=';
        this.headers = new http_1.Headers({ 'Content-Type': 'application/json' });
        this.authHeaders = new http_1.Headers({ 'Authorization': 'Bearer eAzof_R8atIktBYjVwB6y4A5RGiDIqULWg_w48vcQJ_Xoxrx36NmESR6nWYot6LLDNM0fqoOhiFgxf7osuF82a0k4xEaoz_dT6MH2Yj4zphTZxKazytojuHabINuKLbgOvZYtKCYih0I8FbEa_hFd1AC0CYSJmsg6jv9_9mpLN3Ho6eXaVrO0KRHKZhY9Gt01Ju-Ou1kzJY5W6gw_vgOKbOP2WadGY1k4fJYwlx4fnX9Drqeeb0PDNyLACV7Z8bQTV7XzAZhdA9mo3MM5Z-OKgU1rKz-If_PP_UsnBbOHOGsl3RDcRY0bcsiVAhMCLbPW9IRcB8Y6tOtlHW2C2iqyBgRAj_IBC-Us5bIDMnqiNc' });
    }
    ServerService.prototype.createAuthorizationHeader = function (headers2) {
        var acct = document['_accessToken'];
        //headers.append('Content-Type', 'application/json');
        //headers.append('Access-Control-Allow-Origin','*');
        //headers.append('Access-Control-Allow-Methods','GET, POST, PATCH, PUT, DELETE, OPTIONS');
        //headers.append('Access-Control-Allow-Headers','Origin, Content-Type, X-Auth-Token');
        headers2.append('dataType', 'jsonp');
        headers2.append('Authorization', 'Bearer ' + acct);
    };
    ServerService.prototype.createAuthorizationHeaderPost = function (headers2) {
        var acct = document['_accessToken'];
        headers2.append('Content-Type', 'application/json');
        //headers.append('Access-Control-Allow-Origin','*');
        //headers.append('Access-Control-Allow-Methods','GET, POST, PATCH, PUT, DELETE, OPTIONS');
        //headers.append('Access-Control-Allow-Headers','Origin, Content-Type, X-Auth-Token');
        //headers2.append('dataType', 'jsonp');
        headers2.append('Authorization', 'Bearer ' + acct);
    };
    ServerService.prototype.getServers = function () {
        var headers2 = new http_1.Headers();
        this.createAuthorizationHeader(headers2);
        return this.http.get(this.serversUrl, { headers: headers2 })
            .toPromise()
            .then(function (response) { return response.json().data; })
            .catch(this.handleError);
    };
    ServerService.prototype.extractData = function (res) {
        var body = res.json();
        return body.data || {};
    };
    ServerService.prototype.getServer = function (Id) {
        var url = "" + this.detailUrl + ("" + Id);
        var headers2 = new http_1.Headers();
        this.createAuthorizationHeader(headers2);
        return this.http.get(url, { headers: headers2 })
            .toPromise()
            .then(function (response) { return response.json().data; })
            .catch(this.handleError);
    };
    ServerService.prototype.create = function (serverType, nodeName, hostName, planName, ipCount, virtType) {
        var url = 'http://beta.core.markum.net/api/VirtualMachine/Create';
        var headers2 = new http_1.Headers();
        this.createAuthorizationHeaderPost(headers2);
        var obj = {
            "Template": serverType,
            "NodeName": nodeName,
            "HostName": hostName,
            //"UserName": userName,  //    "ugurkizilkaya",  //  
            //"Password": pass,    //"123456",
            "PlanName": planName,
            "IpCount": ipCount,
            "VirtualizationType": virtType //  "SolusVm"   //  
        };
        return this.http.post(url, JSON.stringify(obj), { headers: headers2 })
            .toPromise()
            .then(function (res) { return res.json().data; })
            .catch(this.handleError);
    };
    ServerService.prototype.delete = function (virtualServerId) {
        var url = "" + this.deleteUrl + ("" + virtualServerId);
        //const url = `${this.serversUrl}/${virtualServerId}`;
        var headers2 = new http_1.Headers();
        this.createAuthorizationHeaderPost(headers2);
        return this.http.delete(url, { headers: headers2 })
            .toPromise()
            .then(function () { return null; })
            .catch(this.handleError);
    };
    ServerService.prototype.delete_ = function (virtualServerId) {
        var url = "" + this.deleteUrl + ("" + virtualServerId);
        //const url = `${this.serversUrl}/${virtualServerId}`;
        var headers2 = new http_1.Headers();
        this.createAuthorizationHeaderPost(headers2);
        return this.http.delete(url, { headers: headers2 })
            .map(this.extractData)
            .catch(this.handleError);
    };
    ServerService.prototype.getServers_ = function () {
        //var url = 'http://beta.core.markum.net/api/customeraccount';
        var headers2 = new http_1.Headers();
        this.createAuthorizationHeader(headers2);
        return this.http.get(this.serversUrl, { headers: headers2 })
            .map(this.extractData)
            .catch(this.handleError);
    };
    ServerService.prototype.handleError = function (error) {
        console.error('Bir hata oluştu', error);
        return Promise.reject(error.message || error);
    };
    /////////////////////***************  From separate project **********/////////////////////
    ServerService.prototype.getServers__ = function () {
        return this.http.get(this.serversUrl) //, { headers: this.authHeaders })
            .toPromise()
            .then(function (response) { return response.json().data; })
            .catch(this.handleError);
    };
    ServerService.prototype.getServersSlowly = function () {
        var _this = this;
        return new Promise(function (resolve) {
            setTimeout(function () { return resolve(_this.getServers()); }, 2000);
        });
    };
    ServerService.prototype.update = function (server) {
        var url = this.serversUrl + "/" + server.Id;
        return this.http.put(url, JSON.stringify(server), { headers: this.headers })
            .toPromise()
            .then(function () { return server; })
            .catch(this.handleError);
    };
    ServerService.prototype.create_ = function (name) {
        return this.http.post(this.serversUrl, JSON.stringify({ name: name }), { headers: this.headers })
            .toPromise()
            .then(function (res) { return res.json().data; })
            .catch(this.handleError);
    };
    return ServerService;
}());
ServerService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], ServerService);
exports.ServerService = ServerService;
//# sourceMappingURL=server.service.js.map