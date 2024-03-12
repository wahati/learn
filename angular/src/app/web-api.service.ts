import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
// import { Brand } from './brand';
// import { Observable } from 'rxjs';

@Injectable()
export class WebApiService {

  readonly rootUrl = 'http://localhost:5255/api/';
  constructor(private http: HttpClient) { 
    
  }

  getBrands() {
    return this.http.get(this.rootUrl + 'Brands');
  }

  // getBrands(): Observable<Brand[]> {
  //   return this.http.get<Brand[]>(this.rootUrl + 'Brands');
  // }

  // getBrandsSubscription() {
  //   return this.http.get<Brand[]>(this.rootUrl + 'Brands').subscribe({
  //     next: data => {
  //       console.log(data);
  //     },
  //     error: error => {
  //       console.error('There was an error!', error);
  //     },
  //     complete: () => {
  //       console.log('Completed!');
  //     },
  //   });
  // }
}
