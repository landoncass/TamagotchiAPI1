using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TamagotchiAPI.Models
{
    public class Pet
    {

        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday
        {
            get
            {
                return this.birthday.HasValue ? this.birthday.Value : DateTime.Now;
            }
            set { this.birthday = value; }
        }

        private DateTime? birthday = null;

        public int HungerLevel { get; set; } = 0;
        public int HappinessLevel { get; set; } = 0;

        // public DateTime LastInteractedWithDate
        // {
        //     get
        //     {
        //         return this.interactedWith.HasValue ? this.interactedWith.Value : DateTime.Today;
        //     }
        //     set { this.interactedWith = value; }
        // }

        // private DateTime? interactedWith = null;

        // public bool IsDead()
        // {
        //     if ((LastInteractedWithDate - DateTime.Today) > 3)
        // }
    }
}
