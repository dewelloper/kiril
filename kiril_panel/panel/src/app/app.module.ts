import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { APP_BASE_HREF } from '@angular/common';
// import { ROUTER_PROVIDERS } from '@angular/router-deprecated';

import { AppComponent }   from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';

import { DashboardModule } from './dashboard/dashboard.module';
import { SidebarModule } from './sidebar/sidebar.module';
import { FooterModule } from './shared/footer/footer.module';
import { NavbarModule } from './shared/navbar/navbar.module';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';

import { HttpModule } from '@angular/http';

// Mock web service --- Imports for loading & configuring the in-memory web api 
//import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
//import { InMemoryDataService } from './in-memory-data.service';


//import { CanactivateComponent } from './dashboard/canactivate.component';
//import { CanActivateViaAuthGuard } from './dashboard/canactivateviaauthguard';




@NgModule({
    imports:[
        BrowserModule,        
        DashboardModule,
        SidebarModule,
        NavbarModule,
        FooterModule,
        HttpModule,
        RouterModule.forRoot([])//,
       // InMemoryWebApiModule.forRoot(InMemoryDataService)
    ],
    //declarations: [AppComponent, DashboardComponent, CanactivateComponent],
    //providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }, CanActivateViaAuthGuard],
    declarations: [AppComponent, DashboardComponent],
    providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }],
    bootstrap:    [ AppComponent ]
})
export class AppModule { }
