import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-formularios',
  templateUrl: './formularios.component.html',
  styleUrls: ['./formularios.component.css']
})
export class FormulariosComponent implements OnInit {

  _filtroLista: string;
  get filtroLista(): string{
    return this._filtroLista;
  }
  set filtroLista(value: string){
    this._filtroLista = value;
    this.formularioFiltrados = this.filtroLista ? this.filtrarFormulario(this.filtroLista) : this.formularios;
  }

  formularioFiltrados: any = [];
  formularios: any = [];
  imagemLargura = 50;
  imagemMargem = 2;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getFormularios();
  }

  filtrarFormulario(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.formularios.filter(
      formulario =>
      formulario.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
      || //OU
      formulario.usuario.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
    }

  getFormularios(){
    this.formularios = this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.formularios = response;
      }, error => {
        console.log(error);
      });
  }
}
