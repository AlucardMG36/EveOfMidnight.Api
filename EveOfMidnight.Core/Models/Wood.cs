﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Core.Models
{
    public partial class Wood
    {
        public Guid Id { get; set; }
        public int RarityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsMagical { get; set; }
        public int Maximum { get; set; }

        public virtual Rarity Rarity { get; set; }
    }
}