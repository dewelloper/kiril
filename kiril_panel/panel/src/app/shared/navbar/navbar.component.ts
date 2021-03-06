import { Component, OnInit } from '@angular/core';
import { ROUTES } from '../.././sidebar/sidebar-routes.config';
import { MenuType } from '../.././sidebar/sidebar.metadata';
import { Router, ActivatedRoute } from '@angular/router';
import { Location, LocationStrategy, PathLocationStrategy } from '@angular/common';

@Component({
    moduleId: module.id,
    selector: 'navbar-cmp',
    templateUrl: 'navbar.component.html'
})

export class NavbarComponent implements OnInit {
    private listTitles: any[];
    location: Location;
    constructor(location: Location) {
        this.location = location;
    }

    ngOnInit() {
        this.listTitles = ROUTES.filter(listTitle => listTitle.menuType !== MenuType.BRAND);
    }

    private _menuText: string;

    getTitle() {
        var titlee = this.location.prepareExternalUrl(this.location.path());
        if (titlee.charAt(0) === '#') {
            titlee = titlee.slice(2);
        }
        for (var item = 0; item < this.listTitles.length; item++) {
            if (this.listTitles[item].path === titlee) {
                return this.listTitles[item].title;
            }
        }
        return 'Dashboard';
    }

    getPath() {
        // console.log(this.location);
        return this.location.prepareExternalUrl(this.location.path());
    }
}
