using System;

namespace TamagotchiAPI.Models
{
    public class Playtime
    {
        public int Id { get; set; }
        public DateTime When
        {
            get
            {
                return this.when.HasValue ? this.when.Value : DateTime.Now;
            }
            set { this.When = value; }
        }

        private DateTime? when = null;

        public int PetId { get; set; }
    }
}