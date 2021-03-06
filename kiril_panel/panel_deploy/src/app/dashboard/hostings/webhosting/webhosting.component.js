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
var http_authontication_service_1 = require("../../../Services/http-authontication-service");
var WebhostingComponent = (function () {
    function WebhostingComponent(_httpService) {
        this._httpService = _httpService;
    }
    WebhostingComponent.prototype.onGetFooBars = function () {
        var _this = this;
        this._httpService.getApiAccount().subscribe(function (data) { return _this.Data = JSON.stringify(data); }, function (error) { return alert(error); }, function () { return console.log("finished"); });
    };
    return WebhostingComponent;
}());
WebhostingComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'webhosting-cmp',
        templateUrl: 'webhosting.component.html',
        providers: [http_authontication_service_1.HttpAuthenticationService]
    }),
    __metadata("design:paramtypes", [http_authontication_service_1.HttpAuthenticationService])
], WebhostingComponent);
exports.WebhostingComponent = WebhostingComponent;
//# sourceMappingURL=webhosting.component.js.map