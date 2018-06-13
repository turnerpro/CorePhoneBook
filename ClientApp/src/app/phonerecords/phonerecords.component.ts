import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'phonerecords',
  templateUrl: './phonerecords.component.html',
  styleUrls: ['./phonerecords.component.css'],
})

export class PhonerecordsComponent {
  public phoneRecords: PhoneRecord[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<PhoneRecord[]>(baseUrl + 'api/GetAllPhoneRecords').subscribe(result => {
      this.phoneRecords = result;
      //console.log(result);
    }, error => console.error(error));
  }
}

interface PhoneRecord {
  firstName: string;
  lastName: string;
  phoneNumber: string;
}
