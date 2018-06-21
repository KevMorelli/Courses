import { TestBed, inject } from '@angular/core/testing';

import { HeroApiService } from './hero-api.service';

describe('HeroeApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [HeroApiService]
    });
  });

  it('should be created', inject([HeroApiService], (service: HeroApiService) => {
    expect(service).toBeTruthy();
  }));
});
