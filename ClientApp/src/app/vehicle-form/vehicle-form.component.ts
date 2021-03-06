import { Component, OnInit } from '@angular/core';
import { VehicleService } from "../../services/vehicle.service";

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
    vehicle: any = {
        features: [],
        contact: {}
    };

    /** vehicle-form ctor */
    constructor(
        private vehicleService: VehicleService) {

    }

    ngOnInit(): void {
        this.vehicleService.getMakes().subscribe(makes => this.makes = makes);

        this.vehicleService.getFeature().subscribe(f => this.features = f);
    }

    onMakeChange() {
        var selectedMake = this.makes.find(m => m.id == this.vehicle.makeId);

        this.models = selectedMake ? selectedMake.models : [];

        delete this.vehicle.modelId;
    }

    onFeatureToggle(featureId, $event) {
      if ($event.target.checked) {
        this.vehicle.features.push(featureId);
      } else {
        var index = this.vehicle.features.indexOf(featureId);
        this.vehicle.features.splice(index, 1);
      }
    }

    submit() {
        this.vehicleService.create(this.vehicle).subscribe(
            x => console.log(x));
    }

}
