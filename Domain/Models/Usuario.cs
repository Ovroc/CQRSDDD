using System;
using System.Text.RegularExpressions;

namespace Domain.Models
{
    public class Usuario : Entity
    {
        public Usuario(string nome, string sobrenome, string email, DateTime dataNascimento, int escolaridadeId)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            EscolaridadeId = escolaridadeId;
        }

        public Usuario(int id, string nome, string sobrenome, string email, DateTime dataNascimento, int escolaridadeId)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            DataNascimento = dataNascimento;
            EscolaridadeId = escolaridadeId;
        }

        protected Usuario() { }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public int EscolaridadeId { get; set; }
        public virtual Escolaridade Escolaridade { get; set; }

        public bool IsValidEmail()
        {
            if (string.IsNullOrEmpty(Email))
                return false;

            const string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            
            return regex.IsMatch(Email);
        }

        public bool IsValidBirthDate()
        {
            return DataNascimento <= DateTime.Today;
        }

        public bool IsValidSchooling()
        {
            return Enum.IsDefined(typeof(EscolaridadeEnum), EscolaridadeId);
        }
    }
}
