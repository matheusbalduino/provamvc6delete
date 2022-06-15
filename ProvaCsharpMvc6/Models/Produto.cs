using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaCsharpMvc6.Models
{
    [Owned, Table("Produto")]
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        public string Preco { get; set; }
        public string Codigo { get; set; }
    }
}
