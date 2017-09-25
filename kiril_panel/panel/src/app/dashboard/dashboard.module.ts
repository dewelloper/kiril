import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { MODULE_ROUTES,MODULE_COMPONENTS } from './dashboard.routes';

//import { CanactivateComponent } from './canactivate.component';
import { CanActivateViaAuthGuard } from './canactivateviaauthguard';



//import { DashboardComponent } from './dashboard.component';
import { ServersComponent } from './server/servers/servers.component';
import { ServerService } from './../services/server.service';




@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        RouterModule.forChild(MODULE_ROUTES),
        HttpModule
    ],
    declarations: [
        MODULE_COMPONENTS,
        //DashboardComponent,
        ServersComponent
    ],
    providers: [CanActivateViaAuthGuard, ServerService]
})

export class DashboardModule{}
