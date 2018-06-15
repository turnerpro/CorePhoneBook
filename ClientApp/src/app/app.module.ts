import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { PhonerecordsComponent } from './phonerecords/phonerecords.component';
import { AddRecordComponent } from './add-record/add-record.component';
import { HttpModule } from '@angular/http';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    PhonerecordsComponent,
    AddRecordComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule, ReactiveFormsModule,
    RouterModule.forRoot([
      { path: '', redirectTo: 'phonerecords', pathMatch: 'full' },
      { path: 'phonerecords', component: PhonerecordsComponent },
      { path: 'add-record', component: AddRecordComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
