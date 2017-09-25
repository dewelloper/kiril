import { Route, RouterModule } from '@angular/router';
// import { DashboardComponent } from './dashboard.component';
import { HomeComponent } from './home/home.component';

import { WebhostingComponent } from './hostings/webhosting/webhosting.component';
import { AdddomainComponent } from './hostings/adddomain/adddomain.component';
import { AddsubdomainComponent } from './hostings/addsubdomain/addsubdomain.component';
import { PlansComponent } from './hostings/plans/plans.component';

import { IntransferComponent } from './domains/intransfer/intransfer.component';
import { OuttransferComponent } from './domains/outtransfer/outtransfer.component';
import { ParkingComponent } from './domains/parking/parking.component';
import { DnsComponent } from './domains/dns/dns.component';
import { RelocateComponent } from './domains/relocate/relocate.component';

import { ServerplansComponent } from './server/serverplans/serverplans.component';
import { AddserverComponent } from './server/addserver/addserver.component';
import { ServersComponent } from './server/servers/servers.component';
import { ServerDetailComponent } from './server/servers/server-detail.component';

import { MailhostingaccountComponent } from './mails/mailhostingaccount/mailhostingaccount.component';
import { AddmaildomainComponent } from './mails/addmaildomain/addmaildomain.component';
import { MailplansComponent } from './mails/mailplans/mailplans.component';

import { DatabasesComponent } from './database/databases/databases.component';
import { AdddatabaseComponent } from './database/adddatabase/adddatabase.component';
import { DatabaseplansComponent } from './database/databaseplans/databaseplans.component';

import { AddsslComponent } from './ssl/addssl/addssl.component';
import { SslplansComponent } from './ssl/sslplans/sslplans.component';
import { SslsComponent } from './ssl/ssls/ssls.component';

import { AddlicenceComponent } from './licence/addlicence/addlicence.component';
import { LicenceplansComponent } from './licence/licenceplans/licenceplans.component';
import { LicencesComponent } from './licence/licences/licences.component';

import { AddticketlComponent } from './ticket/addticket/addticket.component';
import { TicketdevelopmentComponent } from './ticket/ticketdevelopment/ticketdevelopment.component';
import { TickethelpComponent } from './ticket/tickethelp/tickethelp.component';

import { SettingaccComponent } from './accounts/accsetting/settingacc.component';
import { AccountComponent } from './accounts/account/account.component';

import { AddcloudserviceComponent } from './cloudservice/addcloudservice/addcloudservice.component';
import { CloudserviceplansComponent } from './cloudservice/cloudserviceplans/cloudserviceplans.component';
import { CloudservicesComponent } from './cloudservice/cloudservices/cloudservices.component';

import { ServicerefreshComponent } from './refreshprocess/servicerefresh/servicerefresh.component';
import { DomainrefreshComponent } from './refreshprocess/domainrefresh/domainrefresh.component';

//import { CanActivateViaAuthGuard } from './canactivateviaauthguard';
import { ChartsComponent } from './charts/charts.component';
import { WidgesComponent } from './widges/widges.component';
import { CalendarComponent } from './calendar/calendar.component';

export const MODULE_ROUTES: Route[] =[
    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
    { path: 'dashboard', component: HomeComponent },

    { path: 'hostings/webhosting', component: WebhostingComponent},
    { path: 'hostings/adddomain', component: AdddomainComponent},
    { path: 'domains/intransfer', component: IntransferComponent },
    { path: 'domains/outtransfer', component: OuttransferComponent},
    { path: 'hostings/addsubdomain', component: AddsubdomainComponent},
    { path: 'hostings/plans', component: PlansComponent},
    { path: 'domains/parking', component: ParkingComponent },
    { path: 'domains/dns', component: DnsComponent },
    { path: 'domains/relocate', component: RelocateComponent },

    { path: 'mails/addmaildomain', component: AddmaildomainComponent},
    { path: 'mails/mailhostingaccount', component: MailhostingaccountComponent},
    { path: 'mails/mailplans', component: MailplansComponent},

    { path: 'server/serverplans', component: ServerplansComponent },
    { path: 'server/addserver', component: AddserverComponent },
    { path: 'server/servers', component: ServersComponent },
    { path: 'server/detail/:id', component: ServerDetailComponent },

    { path: 'database/adddatabase', component: AdddatabaseComponent },
    { path: 'database/databaseplans', component: DatabaseplansComponent },
    { path: 'database/databases', component: DatabasesComponent },

    { path: 'ssl/addssl', component: AddsslComponent },
    { path: 'ssl/sslplans', component: SslplansComponent },
    { path: 'ssl/ssls', component: SslsComponent },

    { path: 'licence/addlicence', component: AddlicenceComponent },
    { path: 'licence/licenceplans', component: LicenceplansComponent },
    { path: 'licence/licences', component: LicencesComponent },

    { path: 'ticket/addticket', component: AddticketlComponent },
    { path: 'ticket/ticketdevelopment', component: TicketdevelopmentComponent },
    { path: 'ticket/tickethelp', component: TickethelpComponent },

    { path: 'accounts/accsetting', component: SettingaccComponent },
    { path: 'accounts/account', component: AccountComponent },

    { path: 'cloudservice/addcloudservice', component: AddcloudserviceComponent },
    { path: 'cloudservice/cloudserviceplans', component: CloudserviceplansComponent },
    { path: 'cloudservice/cloudservices', component: CloudservicesComponent },

    { path: 'refreshprocess/servicerefresh', component: ServicerefreshComponent },
    { path: 'refreshprocess/domainrefresh', component: DomainrefreshComponent },
    

    { path: 'charts', component: ChartsComponent },
    { path: 'widges', component: WidgesComponent }, 
    { path: 'calendar', component: CalendarComponent },
]
//
export const MODULE_COMPONENTS = [
    HomeComponent,

    WebhostingComponent,
    AdddomainComponent,
    IntransferComponent,
    OuttransferComponent,
    AddsubdomainComponent,
    PlansComponent,
    ParkingComponent,
    DnsComponent,
    RelocateComponent,

    MailhostingaccountComponent,
    AddmaildomainComponent,
    MailplansComponent,

    ServerplansComponent,
    AddserverComponent,
    ServersComponent,
    ServerDetailComponent,

    AdddatabaseComponent,
    DatabaseplansComponent,
    DatabasesComponent,

    AddsslComponent,
    SslplansComponent,
    SslsComponent,

    AddlicenceComponent,
    LicenceplansComponent,
    LicencesComponent,

    AddticketlComponent,
    TicketdevelopmentComponent,
    TickethelpComponent,

    SettingaccComponent,
    AccountComponent,

    AddcloudserviceComponent,
    CloudserviceplansComponent,
    CloudservicesComponent,

    ServicerefreshComponent,
    DomainrefreshComponent,

    ChartsComponent,
    CalendarComponent,
    WidgesComponent,
]
