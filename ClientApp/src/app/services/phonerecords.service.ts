import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import { Observable } from 'rxjs/Observable';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';


@Injectable()
export class PhonerecordsService {

  public phoneRecordList: Observable<PhoneRecord[]>;
  private _phoneRecordList: BehaviorSubject<PhoneRecord[]>;
  private baseUrl: string;
  private dataStore: {
    phoneRecordList: PhoneRecord[];
  };

  constructor(private http: Http) {
    this.baseUrl = '/api/';
    this.dataStore = { phoneRecordList: [] };
    this._phoneRecordList = <BehaviorSubject<PhoneRecord[]>>new BehaviorSubject([]);
    this.phoneRecordList = this._phoneRecordList.asObservable();
  }

  getPhoneRecords() {
    this.http.get(`${this.baseUrl}GetAllPhoneRecords`)
      .map(response => response.json())
      .subscribe(data => {
        this.dataStore.phoneRecordList = data;
        this._phoneRecordList.next(Object.assign({}, this.dataStore).phoneRecordList);
      }, error => console.log('Could not load phone records.'));
  }
}

export class PhoneRecord {
  public FirstName: string;
  public LastName: string;
  public PhoneNumber: string;
}

