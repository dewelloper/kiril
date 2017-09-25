import { Component, OnInit } from '@angular/core';
import { ROUTES } from './sidebar-routes.config';
import { MenuType } from './sidebar.metadata';

declare var $:any;

@Component({
    moduleId: module.id,
    selector: 'sidebar-cmp',
    templateUrl: 'sidebar.component.html',
})

export class SidebarComponent implements OnInit {
    public menuItems: any[];

    public CurrentUserName = document['_currUser'] as string;
    public Title = document['_title'] as string;

    ngOnInit() {
        $.getScript('../../src/assets/js/sidebar-moving-tab.js');

        this.menuItems = ROUTES.filter(menuItem => menuItem.menuType !== MenuType.BRAND);

    }

}
