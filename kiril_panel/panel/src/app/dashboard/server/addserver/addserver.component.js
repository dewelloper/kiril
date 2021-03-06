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
var AddserverComponent = (function () {
    function AddserverComponent(router, serverService) {
        this.router = router;
        this.serverService = serverService;
        this.templates = [
            { id: 0, name: "Please Select" },
            { id: 1, name: "Centos6.7-x64-Minimal" },
            { id: 2, name: "windows2012-r2-gen1" }
        ];
        this.selectedValue = this.templates[0];
    }
    AddserverComponent.prototype.addServer = function (nodeName, hostName, planName, ipCount, virtType) {
        var _this = this;
        if (this.selectedValue.id == 0) {
            alert("Please select a valid Server Type!");
            return;
        }
        nodeName = nodeName.trim();
        hostName = hostName.trim();
        planName = planName.trim();
        virtType = virtType.trim();
        //alert("serverName, nodeName, hostName: " + this.selectedValue.name + ", " + userName + ", " + pass + ", " + planName + ", " + ipCount + ", " + virtType );
        this.serverService.create(this.selectedValue.name, nodeName, hostName, planName, ipCount, virtType)
            .then(function () {
            alert("Process successful!");
            _this.router.navigate(['/server/servers']);
        })
            .catch(this.handleError);
    };
    AddserverComponent.prototype.handleError = function (error) {
        console.error('Bir hata olu�tu', error);
        return Promise.reject(error.message || error);
    };
    return AddserverComponent;
}());
AddserverComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'addserver-cmp',
        templateUrl: 'addserver.component.html',
    })
    //class CustomPlan {
    //    Cpu = 1;
    //    Memory = 1;
    //    DiskSpace = 1;
    //    BandWidth = 1;
    //    ExtraIpCount = 1;
    //}
    ,
    __metadata("design:paramtypes", [router_1.Router,
        server_service_1.ServerService])
], AddserverComponent);
exports.AddserverComponent = AddserverComponent;
//# sourceMappingURL=addserver.component.js.map