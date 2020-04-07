import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-formularios',
  templateUrl: './formularios.component.html',
  styleUrls: ['./formularios.component.css']
})
export class FormulariosComponent implements OnInit {
  
  formularios: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getFormularios();
  }
  getFormularios(){
    this.formularios = this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.formularios = response;
      }, error => {
        console.log(error);
      });
  }
}
