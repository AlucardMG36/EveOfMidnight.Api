// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Core.Models
{
    public partial class Rarity
    {
        public Rarity()
        {
            Components = new HashSet<Component>();
            Items = new HashSet<Item>();
            Metals = new HashSet<Metal>();
            StatusEffects = new HashSet<StatusEffect>();
            Woods = new HashSet<Wood>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public decimal? DropRate { get; set; }

        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Metal> Metals { get; set; }
        public virtual ICollection<StatusEffect> StatusEffects { get; set; }
        public virtual ICollection<Wood> Woods { get; set; }
    }
}