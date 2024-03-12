import { Component, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { WebApiService } from './web-api.service';
import { RouterLink } from '@angular/router';
import { Subscription } from 'rxjs';
import { ActivatedRoute } from '@angular/router';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Params } from '@angular/router';
import { Brand } from './brand';
import { CommonModule } from '@angular/common';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import {MatToolbarModule} from '@angular/material/toolbar';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, RouterLink, CommonModule, MatToolbarModule, MatButtonModule, MatIconModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  providers: [WebApiService],
})
export class AppComponent {

  // readonly rootUrl = 'http://localhost:5255/api/';
  brands: Brand[];
  
  title = 'angular';
  // brandsSubscriber: Subscription;

  constructor(
    // httpClient: HttpClient,
    private webApiService: WebApiService,
    // brandsSubscriber: Subscription,
  ) { 
    this.brands = [];
    this.webApiService.getBrands().subscribe({
      next: data => {
        console.log(data);
        this.brands = data as Brand[];
      }
    });
  }
}
