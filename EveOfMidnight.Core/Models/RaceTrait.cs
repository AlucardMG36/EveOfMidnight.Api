﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Core.Models
{
    public partial class RaceTrait
    {
        public Guid RaceId { get; set; }
        public Guid TraitId { get; set; }
        public bool IsPrimaryTrait { get; set; }

        public virtual Race Race { get; set; }
        public virtual Trait Trait { get; set; }
    }
}