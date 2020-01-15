/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { VehicleFormComponent } from './vehicle-form.component';

let component: VehicleFormComponent;
let fixture: ComponentFixture<VehicleFormComponent>;

describe('vehicle-form component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ VehicleFormComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(VehicleFormComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});