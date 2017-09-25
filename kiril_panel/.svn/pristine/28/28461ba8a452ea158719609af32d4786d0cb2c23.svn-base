"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const sidebar_routes_config_1 = require("./sidebar-routes.config");
const sidebar_metadata_1 = require("./sidebar.metadata");
let SidebarComponent = class SidebarComponent {
    constructor() {
        this.CurrentUserName = document['_currUser'];
        this.Title = document['_title'];
    }
    ngOnInit() {
        $.getScript('../../src/assets/js/sidebar-moving-tab.js');
        this.menuItems = sidebar_routes_config_1.ROUTES.filter(menuItem => menuItem.menuType !== sidebar_metadata_1.MenuType.BRAND);
    }
};
SidebarComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'sidebar-cmp',
        templateUrl: 'sidebar.component.html',
    })
], SidebarComponent);
exports.SidebarComponent = SidebarComponent;
//# sourceMappingURL=sidebar.component.js.map