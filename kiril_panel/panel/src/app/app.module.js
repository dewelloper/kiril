"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const platform_browser_1 = require("@angular/platform-browser");
const router_1 = require("@angular/router");
// import { ROUTER_PROVIDERS } from '@angular/router-deprecated';
const app_component_1 = require("./app.component");
const dashboard_component_1 = require("./dashboard/dashboard.component");
const dashboard_module_1 = require("./dashboard/dashboard.module");
const sidebar_module_1 = require("./sidebar/sidebar.module");
const footer_module_1 = require("./shared/footer/footer.module");
const navbar_module_1 = require("./shared/navbar/navbar.module");
const common_1 = require("@angular/common");
const http_1 = require("@angular/http");
// Mock web service --- Imports for loading & configuring the in-memory web api 
//import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
//import { InMemoryDataService } from './in-memory-data.service';
//import { CanactivateComponent } from './dashboard/canactivate.component';
//import { CanActivateViaAuthGuard } from './dashboard/canactivateviaauthguard';
let AppModule = class AppModule {
};
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            dashboard_module_1.DashboardModule,
            sidebar_module_1.SidebarModule,
            navbar_module_1.NavbarModule,
            footer_module_1.FooterModule,
            http_1.HttpModule,
            router_1.RouterModule.forRoot([]) //,
            // InMemoryWebApiModule.forRoot(InMemoryDataService)
        ],
        //declarations: [AppComponent, DashboardComponent, CanactivateComponent],
        //providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }, CanActivateViaAuthGuard],
        declarations: [app_component_1.AppComponent, dashboard_component_1.DashboardComponent],
        providers: [{ provide: common_1.LocationStrategy, useClass: common_1.HashLocationStrategy }],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map