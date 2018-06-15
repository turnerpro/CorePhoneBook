import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { RequestOptions } from '@angular/http';

@Component({
  selector: 'app-add-record',
  templateUrl: './add-record.component.html',
  styleUrls: ['./add-record.component.css']
})
export class AddRecordComponent implements OnInit {

  constructor(private http: HttpClient) {
  }

  ngOnInit() {
  }

  onSubmit(formData: FormData) {
    console.log(formData);
    let url = '/api/AddPhoneRecord'
    return this.http.post(url, JSON.stringify(formData)).subscribe(res => console.log(res));
  }
}

export class PhoneRecord {
  firstName: string;
  lastName: string;
  phoneNumber: string;
}
