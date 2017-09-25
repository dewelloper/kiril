"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var initVectorMap = require("../../../../src/assets/js/init/initVectorMap.js");
var initCharts = require("../../../../src/assets/js/init/charts.js");
var initAniCharts = require("../../../../src/assets/js/init/initAniCharts.js");
var initTooltips = require("../../../../src/assets/js/init/initTooltips.js");
var initNotify = require("../../../../src/assets/js/init/notify.js");
var HomeComponent = (function () {
    function HomeComponent() {
    }
    HomeComponent.prototype.ngOnInit = function () {
        initCharts();
        initVectorMap();
        initNotify();
        initAniCharts();
        initTooltips();
    };
    return HomeComponent;
}());
HomeComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: ' home-cmp ',
        templateUrl: 'home.component.html'
    })
], HomeComponent);
exports.HomeComponent = HomeComponent;
//# sourceMappingURL=home.component.js.map