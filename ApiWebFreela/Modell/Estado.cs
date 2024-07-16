using System.ComponentModel.DataAnnotations;

namespace ApiWebFreela.Modell
{
    public class Estado
    {
        [Key]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O campo Sigla Deve ter 2 caracteres")]
        public string Sigla { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigadorio")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo nome deve conter entre 3 a 200 caracxtres")]
        public string nome { get; set; }

    }
}
