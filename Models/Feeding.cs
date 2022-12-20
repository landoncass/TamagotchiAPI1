using System;

namespace TamagotchiAPI
{
    public class Feeding
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public int PetId { get; set; }
    }
}