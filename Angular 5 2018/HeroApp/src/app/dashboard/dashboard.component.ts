import { Component, OnInit } from '@angular/core';
import { HeroApiService } from './hero-api.service';
import { Hero } from '../Models/hero.model';
import { debug } from 'util';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  heroes: Hero[];
  topHeroes: Hero[];

  canVote: boolean = true;

  constructor(private service: HeroApiService) { }

  ngOnInit() {
    this.service.getHeroes().subscribe(result => {
      this.heroes = result;

      this.orderList();
    });
  }

  orderList() {
    this.heroes.sort(function (a, b) { return (b.votes - a.votes) });

    this.topHeroes = this.heroes.slice(0, 3);
  }

  isFirst(hero: Hero): boolean {
    return this.topHeroes.indexOf(hero) === 0;
  }

  isSecond(hero: Hero): boolean {
    return this.topHeroes.indexOf(hero) === 1;
  }

  isLast(hero: Hero): boolean {
    return this.topHeroes.indexOf(hero) === 2;
  }

  heroVoted(vote: string) {
    this.orderList();
  }

  enableVoting(result: any) {
    this.canVote = result.target.checked;
  }
}
