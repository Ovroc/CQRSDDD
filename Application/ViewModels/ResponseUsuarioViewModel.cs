using Domain.Models;
using System;
using System.Text.Json.Serialization;

namespace Application.ViewModels
{
    public class ResponseUsuarioViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateUp { get; set; }

        [JsonIgnore]
        public int EscolaridadeId { get; set; }
        public string Escolaridade => Enum.GetName(typeof(EscolaridadeEnum), EscolaridadeId);
    }
}
