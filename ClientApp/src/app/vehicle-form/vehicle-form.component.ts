import { Component, OnInit } from '@angular/core';
import { MakeService } from "../../services/make.service";
import { FeatureService } from "../../services/feature.service";

@Component({
    selector: 'app-vehicle-form',
    templateUrl: './vehicle-form.component.html',
    styleUrls: ['./vehicle-form.component.css']
})
/** vehicle-form component*/
export class VehicleFormComponent implements OnInit
{
    makes: any;
    models: any[];
    features: any;
    vehicle: any = {};

    /** vehicle-form ctor */
    constructor(
      private makeService: MakeService,
      private featureService: FeatureService) {

    }

    ngOnInit(): void {
        this.makeService.getMakes().subscribe(makes => this.makes = makes);

        this.featureService.getFeature().subscribe(f => this.features = f);
    }

    onMakeChange() {
        var selectedMake = this.makes.find(m => m.id == this.vehicle.make);

        this.models = selectedMake ? selectedMake.models : [];



    }
}
