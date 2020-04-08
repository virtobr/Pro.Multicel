namespace ProMulticel.Domain
{
    public class FuncionarioFormulario
    {
        public int? FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int? FormularioId { get; set; }
        public Formulario Formulario { get; set; }
    }
}