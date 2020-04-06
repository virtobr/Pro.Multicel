namespace ProMulticel.WebAPI.Model
{
public class Formulario
{
    public int FormularioId { get; set; }
    public string Usuario { get; set; }
    public string Nome { get; set; }
    public string Setor { get; set; }
    public string Superior { get; set; }
    public string Sistema { get; set; }   
    public string PoderesConcedidos { get; set; }
    public string Observacoes { get; set; }
    public string DataFormulario { get; set; }
    public string Filial { get; set; } //3 Sorocaba //1 São Bernardo
    public string ImagemURL { get; set; }
}
}