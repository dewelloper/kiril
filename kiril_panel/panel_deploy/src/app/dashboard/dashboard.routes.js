"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
// import { DashboardComponent } from './dashboard.component';
var home_component_1 = require("./home/home.component");
var webhosting_component_1 = require("./hostings/webhosting/webhosting.component");
var adddomain_component_1 = require("./hostings/adddomain/adddomain.component");
var addsubdomain_component_1 = require("./hostings/addsubdomain/addsubdomain.component");
var plans_component_1 = require("./hostings/plans/plans.component");
var intransfer_component_1 = require("./domains/intransfer/intransfer.component");
var outtransfer_component_1 = require("./domains/outtransfer/outtransfer.component");
var parking_component_1 = require("./domains/parking/parking.component");
var dns_component_1 = require("./domains/dns/dns.component");
var relocate_component_1 = require("./domains/relocate/relocate.component");
var serverplans_component_1 = require("./server/serverplans/serverplans.component");
var addserver_component_1 = require("./server/addserver/addserver.component");
var servers_component_1 = require("./server/servers/servers.component");
var mailhostingaccount_component_1 = require("./mails/mailhostingaccount/mailhostingaccount.component");
var addmaildomain_component_1 = require("./mails/addmaildomain/addmaildomain.component");
var mailplans_component_1 = require("./mails/mailplans/mailplans.component");
var databases_component_1 = require("./database/databases/databases.component");
var adddatabase_component_1 = require("./database/adddatabase/adddatabase.component");
var databaseplans_component_1 = require("./database/databaseplans/databaseplans.component");
var addssl_component_1 = require("./ssl/addssl/addssl.component");
var sslplans_component_1 = require("./ssl/sslplans/sslplans.component");
var ssls_component_1 = require("./ssl/ssls/ssls.component");
var addlicence_component_1 = require("./licence/addlicence/addlicence.component");
var licenceplans_component_1 = require("./licence/licenceplans/licenceplans.component");
var licences_component_1 = require("./licence/licences/licences.component");
var addticket_component_1 = require("./ticket/addticket/addticket.component");
var ticketdevelopment_component_1 = require("./ticket/ticketdevelopment/ticketdevelopment.component");
var tickethelp_component_1 = require("./ticket/tickethelp/tickethelp.component");
var settingacc_component_1 = require("./accounts/accsetting/settingacc.component");
var account_component_1 = require("./accounts/account/account.component");
var addcloudservice_component_1 = require("./cloudservice/addcloudservice/addcloudservice.component");
var cloudserviceplans_component_1 = require("./cloudservice/cloudserviceplans/cloudserviceplans.component");
var cloudservices_component_1 = require("./cloudservice/cloudservices/cloudservices.component");
var servicerefresh_component_1 = require("./refreshprocess/servicerefresh/servicerefresh.component");
var domainrefresh_component_1 = require("./refreshprocess/domainrefresh/domainrefresh.component");
//import { CanActivateViaAuthGuard } from './canactivateviaauthguard';
var charts_component_1 = require("./charts/charts.component");
var widges_component_1 = require("./widges/widges.component");
var calendar_component_1 = require("./calendar/calendar.component");
exports.MODULE_ROUTES = [
    { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
    { path: 'dashboard', component: home_component_1.HomeComponent },
    { path: 'hostings/webhosting', component: webhosting_component_1.WebhostingComponent },
    { path: 'hostings/adddomain', component: adddomain_component_1.AdddomainComponent },
    { path: 'domains/intransfer', component: intransfer_component_1.IntransferComponent },
    { path: 'domains/outtransfer', component: outtransfer_component_1.OuttransferComponent },
    { path: 'hostings/addsubdomain', component: addsubdomain_component_1.AddsubdomainComponent },
    { path: 'hostings/plans', component: plans_component_1.PlansComponent },
    { path: 'domains/parking', component: parking_component_1.ParkingComponent },
    { path: 'domains/dns', component: dns_component_1.DnsComponent },
    { path: 'domains/relocate', component: relocate_component_1.RelocateComponent },
    { path: 'mails/addmaildomain', component: addmaildomain_component_1.AddmaildomainComponent },
    { path: 'mails/mailhostingaccount', component: mailhostingaccount_component_1.MailhostingaccountComponent },
    { path: 'mails/mailplans', component: mailplans_component_1.MailplansComponent },
    { path: 'server/serverplans', component: serverplans_component_1.ServerplansComponent },
    { path: 'server/addserver', component: addserver_component_1.AddserverComponent },
    { path: 'server/servers', component: servers_component_1.ServersComponent },
    { path: 'database/adddatabase', component: adddatabase_component_1.AdddatabaseComponent },
    { path: 'database/databaseplans', component: databaseplans_component_1.DatabaseplansComponent },
    { path: 'database/databases', component: databases_component_1.DatabasesComponent },
    { path: 'ssl/addssl', component: addssl_component_1.AddsslComponent },
    { path: 'ssl/sslplans', component: sslplans_component_1.SslplansComponent },
    { path: 'ssl/ssls', component: ssls_component_1.SslsComponent },
    { path: 'licence/addlicence', component: addlicence_component_1.AddlicenceComponent },
    { path: 'licence/licenceplans', component: licenceplans_component_1.LicenceplansComponent },
    { path: 'licence/licences', component: licences_component_1.LicencesComponent },
    { path: 'ticket/addticket', component: addticket_component_1.AddticketlComponent },
    { path: 'ticket/ticketdevelopment', component: ticketdevelopment_component_1.TicketdevelopmentComponent },
    { path: 'ticket/tickethelp', component: tickethelp_component_1.TickethelpComponent },
    { path: 'accounts/accsetting', component: settingacc_component_1.SettingaccComponent },
    { path: 'accounts/account', component: account_component_1.AccountComponent },
    { path: 'cloudservice/addcloudservice', component: addcloudservice_component_1.AddcloudserviceComponent },
    { path: 'cloudservice/cloudserviceplans', component: cloudserviceplans_component_1.CloudserviceplansComponent },
    { path: 'cloudservice/cloudservices', component: cloudservices_component_1.CloudservicesComponent },
    { path: 'refreshprocess/servicerefresh', component: servicerefresh_component_1.ServicerefreshComponent },
    { path: 'refreshprocess/domainrefresh', component: domainrefresh_component_1.DomainrefreshComponent },
    { path: 'charts', component: charts_component_1.ChartsComponent },
    { path: 'widges', component: widges_component_1.WidgesComponent },
    { path: 'calendar', component: calendar_component_1.CalendarComponent },
];
//
exports.MODULE_COMPONENTS = [
    home_component_1.HomeComponent,
    webhosting_component_1.WebhostingComponent,
    adddomain_component_1.AdddomainComponent,
    intransfer_component_1.IntransferComponent,
    outtransfer_component_1.OuttransferComponent,
    addsubdomain_component_1.AddsubdomainComponent,
    plans_component_1.PlansComponent,
    parking_component_1.ParkingComponent,
    dns_component_1.DnsComponent,
    relocate_component_1.RelocateComponent,
    mailhostingaccount_component_1.MailhostingaccountComponent,
    addmaildomain_component_1.AddmaildomainComponent,
    mailplans_component_1.MailplansComponent,
    serverplans_component_1.ServerplansComponent,
    addserver_component_1.AddserverComponent,
    servers_component_1.ServersComponent,
    adddatabase_component_1.AdddatabaseComponent,
    databaseplans_component_1.DatabaseplansComponent,
    databases_component_1.DatabasesComponent,
    addssl_component_1.AddsslComponent,
    sslplans_component_1.SslplansComponent,
    ssls_component_1.SslsComponent,
    addlicence_component_1.AddlicenceComponent,
    licenceplans_component_1.LicenceplansComponent,
    licences_component_1.LicencesComponent,
    addticket_component_1.AddticketlComponent,
    ticketdevelopment_component_1.TicketdevelopmentComponent,
    tickethelp_component_1.TickethelpComponent,
    settingacc_component_1.SettingaccComponent,
    account_component_1.AccountComponent,
    addcloudservice_component_1.AddcloudserviceComponent,
    cloudserviceplans_component_1.CloudserviceplansComponent,
    cloudservices_component_1.CloudservicesComponent,
    servicerefresh_component_1.ServicerefreshComponent,
    domainrefresh_component_1.DomainrefreshComponent,
    charts_component_1.ChartsComponent,
    calendar_component_1.CalendarComponent,
    widges_component_1.WidgesComponent,
];
//# sourceMappingURL=dashboard.routes.js.map