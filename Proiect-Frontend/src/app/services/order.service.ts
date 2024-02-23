  // src/app/services/order.service.ts
  import { Injectable } from '@angular/core';
  import { HttpClient } from '@angular/common/http';
  import { Observable } from 'rxjs';

  @Injectable({
    providedIn: 'root'
  })
  export class OrderService {
    private ordersUrl = 'http://localhost:5230/api/orders'; 

    constructor(private http: HttpClient) {}

    getOrders(): Observable<any[]> {
      return this.http.get<any[]>(this.ordersUrl);
    }

    
  }
