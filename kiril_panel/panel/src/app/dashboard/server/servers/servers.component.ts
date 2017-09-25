import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Server } from './../../server';
import { ServerService } from './../../../services/server.service';

import 'rxjs/add/operator/catch'; 

declare var $: any;
declare var swal: any;

@Component({
    moduleId: module.id,
    selector: 'servers-cmp',
    templateUrl: 'servers.component.html',
    //styleUrls: ['./servers.component.css', './../styles.css']
})



export class ServersComponent implements OnInit{
    servers: Server[];
    selectedServer: Server;
    responseData: any;

    constructor(
        private router: Router,
        private serverService: ServerService
    ) { }

    ngOnInit(): void {
        this.getServers();
    }

    getServers(): void {
        this.serverService.getServers().then(servers => this.servers = servers);
    }

    getServers_(): void {
        this.serverService.getServers_()
            .subscribe(
                data => this.responseData = JSON.stringify(data),
                error => alert(error),
                () => console.log("finished"));        
    }

    onSelect(server: Server): void {
        this.selectedServer = server;
    }

    gotoDetail(server: Server): void {
        this.router.navigate(['/server/detail', server.VirtualServerId]);
    }

    private handleError(error: any): Promise<any> {
        console.error('Bir hata oluþtu', error);
        return Promise.reject(error.message || error);
    }

    deleteJob(server: Server): void {
        this.serverService.delete(server.VirtualServerId)
            .then(() => {
                this.servers = this.servers.filter(h => h !== server);
                if (this.selectedServer === server) { this.selectedServer = null; }
                console.log("success!");
                swal({
                    title: 'Deleted!',
                    text: 'Your Server has been deleted.',
                    type: 'success',
                    confirmButtonClass: "btn btn-success",
                    buttonsStyling: false
                })
            })
            .catch(this.handleError);        
    }   

    delete(server: Server): void {

        swal({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            type: 'warning',
            showCancelButton: true,
            confirmButtonClass: 'btn btn-success',
            cancelButtonClass: 'btn btn-danger',
            confirmButtonText: 'Yes, delete it!',
            buttonsStyling: false
        }).then(this.deleteJob(server));            
                
    }
}

    /*add(name: string): void {
        name = name.trim();
        if (!name) {            
            return;
        }       

        this.serverService.create(name)
            .then(server => {
                this.servers.push(server);
                this.selectedServer = null;
            });
    }*/

//this.serverService.delete(server.VirtualServerId)
//    .then(() => {
//        this.servers = this.servers.filter(h => h !== server);
//        if (this.selectedServer === server) { this.selectedServer = null; }

//    });

//this.serverService.delete_(server.VirtualServerId)
//    .subscribe(
//    data => {
//        this.servers = this.servers.filter(h => h !== server);
//        if (this.selectedServer === server) { this.selectedServer = null; }
//    },
//    error => alert(error),
//    () => console.log("finished"));
