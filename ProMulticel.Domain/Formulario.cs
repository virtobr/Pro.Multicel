using System;
using System.Collections.Generic;

namespace ProMulticel.Domain
{
public class Formulario
{
    public int Id { get; set; }
    // public string Nome { get; set; }
    // public string Setor { get; set; }
    // public string Superior { get; set; }
    public string Sistema { get; set; }   
    public string PoderesConcedidos { get; set; }
    public string Observacoes { get; set; }
    public DateTime DataFormulario { get; set; }
    public string Filial { get; set; } //3 Sorocaba //1 São Bernardo
    public string ImagemURL { get; set; }
    // public string Email { get; set; }
    public List<FuncionarioFormulario> FuncionarioFormularios { get; set; }
    
}
}