using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Trigre.Entity
{
    [Table("Bot")]
    public class Bot
    {
        [Key]
        public int BotId { get; set; }
        [Required(ErrorMessage = "Informe o login do usuário.")]
        [Display(Name = "Usuário")]
        public string BotNome { get; set; }
       
    }
}
