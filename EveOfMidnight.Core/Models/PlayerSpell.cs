// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Core.Models
{
    public partial class PlayerSpell
    {
        public Guid PlayerCharacterId { get; set; }
        public Guid SpellId { get; set; }
        public int Dots { get; set; }

        public virtual PlayerCharacter PlayerCharacter { get; set; }
        public virtual Spell Spell { get; set; }
    }
}