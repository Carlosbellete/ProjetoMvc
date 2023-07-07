using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoMvc.Models
{
    [Table("Contato")]
    public class Contato
    {
        [Column("Id")]
        [Display(Name ="Id")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Column("Ativo")]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
    }
}
