using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
    }
}