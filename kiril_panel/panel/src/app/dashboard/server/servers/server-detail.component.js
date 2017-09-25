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
require("rxjs/add/operator/switchMap");
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var common_1 = require("@angular/common");
var server_service_1 = require("./../../../services/server.service");
var ServerDetailComponent = (function () {
    function ServerDetailComponent(serverService, route, location) {
        this.serverService = serverService;
        this.route = route;
        this.location = location;
    }
    ServerDetailComponent.prototype.ngOnInit = function () {
        var _this = this;
        this.route.params
            .switchMap(function (params) { return _this.serverService.getServer(+params['id']); })
            .subscribe(function (server) { return _this.server = server; });
    };
    ServerDetailComponent.prototype.goBack = function () {
        this.location.back();
    };
    ServerDetailComponent.prototype.save = function () {
        var _this = this;
        this.serverService.update(this.server)
            .then(function () { return _this.goBack(); });
    };
    return ServerDetailComponent;
}());
ServerDetailComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'servers-cmp',
        templateUrl: './server-detail.component.html',
        styleUrls: ['./server-detail.component.css']
    }),
    __metadata("design:paramtypes", [server_service_1.ServerService,
        router_1.ActivatedRoute,
        common_1.Location])
], ServerDetailComponent);
exports.ServerDetailComponent = ServerDetailComponent;
//# sourceMappingURL=server-detail.component.js.map