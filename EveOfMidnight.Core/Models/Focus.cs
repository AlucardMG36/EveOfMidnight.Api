﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Core.Models
{
    public partial class Focus
    {
        public Focus()
        {
            Spells = new HashSet<Spell>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string IconName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Spell> Spells { get; set; }
    }
}