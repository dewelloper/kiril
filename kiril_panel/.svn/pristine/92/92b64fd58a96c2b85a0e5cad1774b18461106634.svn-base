import { Component } from '@angular/core';
import { HttpAuthenticationService } from '../../../Services/http-authontication-service';

 
@Component({
    moduleId: module.id,
    selector: 'webhosting-cmp',
    templateUrl: 'webhosting.component.html',
    providers: [HttpAuthenticationService]
})

export class WebhostingComponent{
    Data: any;

    constructor(private _httpService: HttpAuthenticationService) { }

    onGetFooBars() {

        this._httpService.getApiAccount().subscribe(data => this.Data = JSON.stringify(data),
            error => alert(error),
            () => console.log("finished")
        );
    }

}
