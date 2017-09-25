"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const router_1 = require("@angular/router");
const platform_browser_1 = require("@angular/platform-browser");
const forms_1 = require("@angular/forms");
const http_1 = require("@angular/http");
const dashboard_routes_1 = require("./dashboard.routes");
//import { CanactivateComponent } from './canactivate.component';
const canactivateviaauthguard_1 = require("./canactivateviaauthguard");
//import { DashboardComponent } from './dashboard.component';
const servers_component_1 = require("./server/servers/servers.component");
const server_service_1 = require("./../services/server.service");
let DashboardModule = class DashboardModule {
};
DashboardModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            forms_1.FormsModule,
            router_1.RouterModule.forChild(dashboard_routes_1.MODULE_ROUTES),
            http_1.HttpModule
        ],
        declarations: [
            dashboard_routes_1.MODULE_COMPONENTS,
            //DashboardComponent,
            servers_component_1.ServersComponent
        ],
        providers: [canactivateviaauthguard_1.CanActivateViaAuthGuard, server_service_1.ServerService]
    })
], DashboardModule);
exports.DashboardModule = DashboardModule;
//# sourceMappingURL=dashboard.module.js.map