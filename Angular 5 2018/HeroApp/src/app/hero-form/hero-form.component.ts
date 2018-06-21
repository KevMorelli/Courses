import { Component, OnInit } from '@angular/core';
import { Hero } from '../Models/hero.model';
import { HeroApiService } from '../dashboard/hero-api.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-hero-form',
  templateUrl: './hero-form.component.html',
  styleUrls: ['./hero-form.component.scss']
})
export class HeroFormComponent implements OnInit {

  hero: Hero;

  constructor(private service: HeroApiService, private router: Router) {
    this.hero = new Hero();
  }

  ngOnInit() {
  }

  createHero() {
    this.service.save(this.hero).subscribe(result => {
      this.router.navigate(['/heroes'])
    });
  }

}
