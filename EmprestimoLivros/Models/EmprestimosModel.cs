namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        //Os atribuitos aqui referenciarão os campos no Banco de Dados
        public int Id { get; set; }
        public string Recebedor { get; set; }
        public string Fornecedor { get; set; }
        public string LivroEmprestado { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
