import { Component, OnInit } from '@angular/core';
import initVectorMap = require('../../../../src/assets/js/init/initVectorMap.js');
import initCharts = require('../../../../src/assets/js/init/charts.js');
import initAniCharts = require('../../../../src/assets/js/init/initAniCharts.js');
import initTooltips = require('../../../../src/assets/js/init/initTooltips.js');
import initNotify = require('../../../../src/assets/js/init/notify.js');

@Component({
    moduleId: module.id,
    selector: ' home-cmp ',
    templateUrl: 'home.component.html'
})

export class HomeComponent implements OnInit{
    ngOnInit(){
        initCharts();
        initVectorMap();
        initNotify();
        initAniCharts();
        initTooltips();
    }
}
