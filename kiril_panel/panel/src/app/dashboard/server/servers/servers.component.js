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
var router_1 = require("@angular/router");
var server_service_1 = require("./../../../services/server.service");
require("rxjs/add/operator/catch");
var ServersComponent = (function () {
    function ServersComponent(router, serverService) {
        this.router = router;
        this.serverService = serverService;
    }
    ServersComponent.prototype.ngOnInit = function () {
        this.getServers();
    };
    ServersComponent.prototype.getServers = function () {
        var _this = this;
        this.serverService.getServers().then(function (servers) { return _this.servers = servers; });
    };
    ServersComponent.prototype.getServers_ = function () {
        var _this = this;
        this.serverService.getServers_()
            .subscribe(function (data) { return _this.responseData = JSON.stringify(data); }, function (error) { return alert(error); }, function () { return console.log("finished"); });
    };
    ServersComponent.prototype.onSelect = function (server) {
        this.selectedServer = server;
    };
    ServersComponent.prototype.gotoDetail = function (server) {
        this.router.navigate(['/server/detail', server.VirtualServerId]);
    };
    ServersComponent.prototype.handleError = function (error) {
        console.error('Bir hata olu�tu', error);
        return Promise.reject(error.message || error);
    };
    ServersComponent.prototype.deleteJob = function (server) {
        var _this = this;
        this.serverService.delete(server.VirtualServerId)
            .then(function () {
            _this.servers = _this.servers.filter(function (h) { return h !== server; });
            if (_this.selectedServer === server) {
                _this.selectedServer = null;
            }
            console.log("success!");
            swal({
                title: 'Deleted!',
                text: 'Your Server has been deleted.',
                type: 'success',
                confirmButtonClass: "btn btn-success",
                buttonsStyling: false
            });
        })
            .catch(this.handleError);
    };
    ServersComponent.prototype.delete = function (server) {
        swal({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonClass: 'btn btn-success',
            cancelButtonClass: 'btn btn-danger',
            confirmButtonText: 'Yes, delete it!',
            buttonsStyling: false
        }).then(this.deleteJob(server));
    };
    return ServersComponent;
}());
ServersComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'servers-cmp',
        templateUrl: 'servers.component.html',
    }),
    __metadata("design:paramtypes", [router_1.Router,
        server_service_1.ServerService])
], ServersComponent);
exports.ServersComponent = ServersComponent;
/*add(name: string): void {
    name = name.trim();
    if (!name) {
        return;
    }

    this.serverService.create(name)
        .then(server => {
            this.servers.push(server);
            this.selectedServer = null;
        });
}*/
//this.serverService.delete(server.VirtualServerId)
//    .then(() => {
//        this.servers = this.servers.filter(h => h !== server);
//        if (this.selectedServer === server) { this.selectedServer = null; }
//    });
//this.serverService.delete_(server.VirtualServerId)
//    .subscribe(
//    data => {
//        this.servers = this.servers.filter(h => h !== server);
//        if (this.selectedServer === server) { this.selectedServer = null; }
//    },
//    error => alert(error),
//    () => console.log("finished"));
//# sourceMappingURL=servers.component.js.map