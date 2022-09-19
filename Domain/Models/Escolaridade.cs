namespace Domain.Models
{
    public class Escolaridade : Entity
    {
        public string Descricao { get; set; }
    }

    public enum EscolaridadeEnum
    {
        Infantil = 1,
        Fundamental = 2,
        Medio = 3,
        Superior = 4
    }
}
