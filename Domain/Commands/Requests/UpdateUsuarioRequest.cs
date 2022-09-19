using MediatR;
using System;

namespace Domain.Commands.Requests
{
    public class UpdateUsuarioRequest : IRequest<UsuarioResponse>
    {
        public UpdateUsuarioRequest(int id, string nome, string sobreNome, string email, DateTime dataNascimento, int escolaridadeId)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobreNome;
            Email = email;
            DataNascimento = dataNascimento;
            EscolaridadeId = escolaridadeId;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int EscolaridadeId { get; set; }
    }
}
