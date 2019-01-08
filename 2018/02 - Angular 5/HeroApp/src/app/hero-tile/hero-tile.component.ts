import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Hero } from '../Models/hero.model';

@Component({
  selector: 'app-hero-tile',
  templateUrl: './hero-tile.component.html',
  styleUrls: ['./hero-tile.component.scss']
})
export class HeroTileComponent implements OnInit {
  @Input() hero: Hero;
  @Input() isFirst: boolean;
  @Input() isSecond: boolean;
  @Input() isLast: boolean;
  @Input() canVote: boolean;

  constructor() {
  }

  ngOnInit() {
  }

  @Output() onVoted = new EventEmitter<String>();
  voteHero(vote: number) {
    this.hero.votes += vote;
    this.onVoted.emit("");
  }
}

