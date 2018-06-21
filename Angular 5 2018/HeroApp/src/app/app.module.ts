import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HeroApiService } from './dashboard/hero-api.service';
import { HttpClientModule } from '@angular/common/http';
import { HeroTileComponent } from './hero-tile/hero-tile.component';
import { Routes, RouterModule } from '@angular/router';
import { HeroDetailComponent } from './hero-detail/hero-detail.component';
import { HeroListComponent } from './hero-list/hero-list.component';
import { HeroFormComponent } from './hero-form/hero-form.component';

const appRoutes: Routes = [
  { path: '', component: DashboardComponent },
  { path: 'hero/:id', component: HeroDetailComponent },
  { path: 'heroes', component: HeroListComponent },
  { path: 'create', component: HeroFormComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    HeroTileComponent,
    HeroDetailComponent,
    HeroListComponent,
    HeroFormComponent
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule.forRoot(
      appRoutes,
      { enableTracing: false } // <-- debugging purposes only
    )

  ],
  providers: [HeroApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
