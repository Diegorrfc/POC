using System;
namespace Trigre.ViewModel
{
    public class UserViewModel
    {
        [Table("User")]
        public UserViewModel()
        {       
            [Key]
            public int UserId { get; set; }
            [Required(ErrorMessage = "Informe o login do usuário.")]
            [Display(Name = "Usuário")]
            public string Nome { get; set; }
            [Required(ErrorMessage = "Informe o email do usuário.")]
            public string Email { get; set; }

        
        }
    }
}
