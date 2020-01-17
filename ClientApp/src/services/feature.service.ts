import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class FeatureService {
  constructor(private http: HttpClient) {

  }

  getFeature() {
    return this.http.get("/api/features");
  }
}
