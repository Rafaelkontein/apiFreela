using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ApiWebFreela.Modell
{
    [Table("login")]
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string email { get; set; } 
    }
}
