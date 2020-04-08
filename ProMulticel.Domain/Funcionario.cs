using System.Collections.Generic;

namespace ProMulticel.Domain
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Setor { get; set; }
        public string Superior { get; set; }
        public List<FuncionarioFormulario> FuncionarioFormularios { get; set; }
    }
}