import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Hero } from '../Models/hero.model';

@Injectable()
export class HeroApiService {

  constructor(private http: HttpClient) { }

  getHeroes(): Observable<any> {
    let url = 'https://acntourofheroes.azurewebsites.net/api/heroes';

    return this.http.get(url).map((Response: any) => Hero.fromJsonArray(Response.data));
  }

  save(hero: Hero): Observable<Hero> {
    if (hero.id) {
      return this.put(hero);
    }
    return this.post(hero);
  }

  // Add new Hero
  private post(hero: Hero): Observable<Hero> {

    return this.http
      .post("https://acntourofheroes.azurewebsites.net/api/heroes/", hero)
      .map(r => Hero.fromJson(r));
  }

  // Update existing Hero
  private put(hero: Hero): Observable<Hero> {

    const url = "https://acntourofheroes.azurewebsites.net/api/heroes/" + 'Edit/' + hero.id;

    return this.http
      .post(url, hero)
      .map(r => Hero.fromJson(r))
  }

}
