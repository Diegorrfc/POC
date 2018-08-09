using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Trigre.Entity
{
    [Table("User")]
    public class User
    {
            [Key]
            public int UserId { get; set; }
            [Required(ErrorMessage = "Informe o login do usuário.")]
            [Display(Name = "Usuário")]
            public string Nome { get; set; }
            [Required(ErrorMessage = "Informe a senha do usuário.")]
            [DataType(DataType.Password)]
            public string Senha { get; set; }
            [Required(ErrorMessage = "Informe o email do usuário.")]
            public string Email { get; set; }

    }
}

