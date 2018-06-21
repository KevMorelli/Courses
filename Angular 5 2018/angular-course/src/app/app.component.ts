import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Hola Mundo';
  heroes: string[];

  changeTitle(): void {
    this.title = "Changed";
  }

  cargaData(): void {
    this.heroes = ["heroe1", "heroe2"];
  }

}
