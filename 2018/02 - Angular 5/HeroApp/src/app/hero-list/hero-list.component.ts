import { Component, OnInit } from '@angular/core';
import { HeroApiService } from '../dashboard/hero-api.service';
import { Hero } from '../Models/hero.model';

@Component({
  selector: 'app-hero-list',
  templateUrl: './hero-list.component.html',
  styleUrls: ['./hero-list.component.scss']
})
export class HeroListComponent implements OnInit {
  heroes: Hero[];
  filteredHeroes: Hero[];
  constructor(private service: HeroApiService) { }

  ngOnInit() {
    this.service.getHeroes().subscribe(result => {
      this.heroes = result;
      this.filteredHeroes = this.heroes;
    })
  }

  filterHeroes(result: any) {
    this.filteredHeroes = [];

    if (result.target.value == "") {
      this.filteredHeroes = this.heroes;
    }
    else {
      this.heroes.forEach(hero => {
        if (hero.name.toLowerCase().includes(result.target.value.toLowerCase())) {
          this.filteredHeroes.push(hero);
        }
      });
    }
  }
}
