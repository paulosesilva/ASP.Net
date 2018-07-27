using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Descricao { get; set; }
    }
}