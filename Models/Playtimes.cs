using System;

namespace TamagotchiAPI
{
    public class Playtimes
    {
        public int Id { get; set; }
        public DateTime When { get; set; }
        public int PetId { get; set; }
    }
}