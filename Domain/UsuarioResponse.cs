using System;

namespace Domain
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public int EscolaridadeId { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateUp { get; set; }
    }
}
