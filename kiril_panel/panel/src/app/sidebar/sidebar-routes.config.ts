﻿import { MenuType, RouteInfo } from './sidebar.metadata';

export const ROUTES: RouteInfo[] = [
    { path: 'dashboard', title: 'Ana Sayfa', menuType: MenuType.LEFT, icon: 'material-icons' },

    { path: 'accounts/account', title: 'My Account', menuType: MenuType.LEFT, icon:'material-icons' },
    { path: 'accounts/accsetting', title: 'Settings', menuType: MenuType.LEFT, icon:'material-icons' },

    { path: 'hostings/webhosting', title: 'Web Hosting Hesapları', menuType: MenuType.LEFT, icon:'' },
    { path: 'hostings/adddomain', title: 'Domain Ekle', menuType: MenuType.LEFT, icon:'pe-7s-plugin' },
    { path: 'hostings/addsubdomain', title: 'Alt Domain Ekle', menuType: MenuType.LEFT, icon:'pe-7s-plugin' },
    { path: 'hostings/plans', title: 'Planlar', menuType: MenuType.LEFT, icon:'pe-7s-plugin' },

    { path: 'domains/outtransfer', title: 'Dış Transfer', menuType: MenuType.LEFT, icon: 'pe-7s-plugin' },
    { path: 'domains/intransfer', title: 'İç Transfer', menuType: MenuType.LEFT, icon:'pe-7s-plugin' },
    { path: 'domains/parking', title: 'Parking Hizmeti', menuType: MenuType.LEFT, icon: 'pe-7s-plugin' },
    { path: 'domains/relocate', title: 'Yönlendirme', menuType: MenuType.LEFT, icon: 'pe-7s-plugin' },
    { path: 'domains/dns', title: 'Dns', menuType: MenuType.LEFT, icon: 'pe-7s-plugin' },

    { path: 'mails/mailhostingaccount', title: 'Mail Hosting Hesapları', menuType: MenuType.LEFT, icon:'pe-7s-note2' },
    { path: 'mails/addmaildomain', title: 'Mail Domain Ekleme', menuType: MenuType.LEFT, icon:'pe-7s-note2' },
    { path: 'mails/mailplans', title: 'Planlar', menuType: MenuType.LEFT, icon: 'pe-7s-note2' },

    { path: 'server/servers', title: 'Sunucular', menuType: MenuType.LEFT, icon:'pe-7s-note2' },    
    { path: 'server/addserver', title: 'Sunucu Ekle', menuType: MenuType.LEFT, icon:'pe-7s-news-paper' },
    { path: 'server/serverplans', title: 'Planlar', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },

    { path: 'database/databases', title: 'Veritabanları', menuType: MenuType.LEFT, icon:'pe-7s-news-paper' },
    { path: 'database/adddatabase', title: 'Veritabanı Ekle', menuType: MenuType.LEFT, icon:'pe-7s-map-marker' },
    { path: 'database/databaseplans', title: 'Planlar', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },

    { path: 'ssl/ssls', title: 'Sertifikalar', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },
    { path: 'ssl/addssl', title: 'Sertifika Ekle', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },
    { path: 'ssl/sslplans', title: 'Planlar', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },

    { path: 'licence/licences', title: 'Lisanslar', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },
    { path: 'licence/addlicence', title: 'Lisans Ekle', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },
    { path: 'licence/licenceplans', title: 'Lisans Planları', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },
    

    { path: 'ticket/addticket', title: 'Ticket Ekle', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },
    { path: 'ticket/ticketdevelopment', title: 'Geliştirme Talepleri', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },
    { path: 'ticket/tickethelp', title: 'Yardım', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },

    { path: 'cloudservice/addcloudservice', title: 'Bulut Servis Ekle', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },
    { path: 'cloudservice/cloudserviceplans', title: 'Bulut Servis Planları', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },
    { path: 'cloudservice/cloudservices', title: 'Bulut Servisler', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },

    { path: 'refreshprocess/servicerefresh', title: 'Hizmet Yenileme', menuType: MenuType.LEFT, icon: 'pe-7s-news-paper' },
    { path: 'refreshprocess/domainrefresh', title: 'Domain Yenileme', menuType: MenuType.LEFT, icon: 'pe-7s-map-marker' },

    //{ path: 'maps/vector', title: 'Vector Map', menuType: MenuType.LEFT, icon:'pe-7s-map-marker' },
    { path: 'widges', title: 'Widges', menuType: MenuType.LEFT, icon:'material-icons' },
    { path: 'charts', title: 'Charts', menuType: MenuType.LEFT, icon:'material-icons' },
    { path: 'calendar', title: 'Calendar', menuType: MenuType.LEFT, icon:'material-icons' },



];