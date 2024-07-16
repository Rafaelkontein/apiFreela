using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ApiWebFreela.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;

namespace ApiWebFreela.Modell
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Nome deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de nacimento não pode ser vazia")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "A data de nacimento está incorreta")]
        public string DataNacimento { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "O campo Senha deve conter entre 6 e 100 caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Número de celular está incorreto")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "o telefone está incorreto")]
        public string celular { get; set; }

        [Required(ErrorMessage = "O email nao pode ser vazio")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Email incorreto")]
        public string email { get; set; }

        [Required(ErrorMessage ="O campo Cpf deve conter  exatmente 11 caracteres")]
        [StringLength (11, MinimumLength =11, ErrorMessage = "O campo Cpf deve conter  exatmente 11 caracteres")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "O cep não pode estar vazio")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O cep deve ter 9 caracteres")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Rua é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo Rua deve conter entre 3 e 200 caracteres")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "O campo Número deve conter entre 1 e 10 caracteres")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Bairro deve conter entre 3 e 100 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo Cidade deve conter entre 3 e 100 caracteres")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo UF é obrigatório")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "O campo UF deve conter 2 caracteres")]
        public string UF { get; set; }

        [Required(ErrorMessage = "o campo profissao é obrigario")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "o campo profissao é obrigario")]
        public string profissao { get; set; }

        [Required(ErrorMessage = "o campo regiao atendida é obrigatorio")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "o campo profissao é obrigario")]
        public string regiaoAtendida { get; set; }
    }


}
