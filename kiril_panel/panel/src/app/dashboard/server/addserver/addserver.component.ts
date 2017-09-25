import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ServerService } from './../../../services/server.service';

import 'rxjs/add/operator/catch'; 
//import { HttpAuthenticationService } from '../../../Services/http-authontication-service';

declare var $: any;

@Component({
    moduleId: module.id,
    selector: 'addserver-cmp',
    templateUrl: 'addserver.component.html',
    //providers: [HttpAuthenticationService]
})

//class CustomPlan {
//    Cpu = 1;
//    Memory = 1;
//    DiskSpace = 1;
//    BandWidth = 1;
//    ExtraIpCount = 1;
//}

export class AddserverComponent  {
    templates = [
        { id: 0, name: "Please Select" },
        { id: 1, name: "Centos6.7-x64-Minimal" },
        { id: 2, name: "windows2012-r2-gen1" }        
    ];
    selectedValue = this.templates[0];
    
    Data: any;
    constructor(
        private router: Router,
        private serverService: ServerService        
    ) { }

    addServer(nodeName: string, hostName: string, planName: string, ipCount: number, virtType: string): void {        
        if (this.selectedValue.id == 0) {
            alert("Please select a valid Server Type!");                
            return;
        }  

        nodeName = nodeName.trim();
        hostName = hostName.trim();        
        planName = planName.trim();
        virtType = virtType.trim();
        
        //alert("serverName, nodeName, hostName: " + this.selectedValue.name + ", " + userName + ", " + pass + ", " + planName + ", " + ipCount + ", " + virtType );

        this.serverService.create(this.selectedValue.name, nodeName, hostName, planName,ipCount, virtType)
            .then(() => {
                alert("Process successful!"); 
                this.router.navigate(['/server/servers']);               
            })
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('Bir hata oluþtu', error);
        return Promise.reject(error.message || error);
    }

    //onSetCreateVM() {
        //this._httpService.getApiAccount().subscribe(data => this.Data = JSON.stringify(data),
        //    error => alert(error),
        //    () => console.log("finished")
        //);
    //}
 
}
