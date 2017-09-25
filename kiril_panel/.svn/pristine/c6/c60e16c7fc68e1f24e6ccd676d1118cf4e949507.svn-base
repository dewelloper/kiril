import 'rxjs/add/operator/switchMap';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';
import { Location } from '@angular/common';

import { Server } from './../../server';
import { ServerService } from './../../../services/server.service';


@Component({
    moduleId: module.id,
    selector: 'servers-cmp',
    templateUrl: './server-detail.component.html',
    styleUrls: ['./server-detail.component.css']
})

export class ServerDetailComponent implements OnInit {
    server: Server;

    constructor(
        private serverService: ServerService,
        private route: ActivatedRoute,
        private location: Location
    ) { }

    ngOnInit(): void {
        this.route.params
            .switchMap((params: Params) => this.serverService.getServer(+params['id']))
            .subscribe(server => this.server = server);
    }

    goBack(): void {
        this.location.back();
    }

    save(): void {
        this.serverService.update(this.server)
            .then(() => this.goBack());
    }
}