using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModels
{
    public class RequestUsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Name")]
        public string Nome { get; set; }

        [MinLength(2)]
        [MaxLength(50)]
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        public int EscolaridadeId { get; set; }
    }
}
