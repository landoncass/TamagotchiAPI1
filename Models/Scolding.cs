using System;

namespace TamagotchiAPI
{
    public class Scolding
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public int PetId { get; set; }
    }
}