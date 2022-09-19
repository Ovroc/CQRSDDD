using System;

namespace Domain.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime? DateUp { get; set; }
    }
}
