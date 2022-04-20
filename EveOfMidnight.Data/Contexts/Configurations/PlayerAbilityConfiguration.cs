﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EveOfMidnight.Data.Contexts;
using EveOfMidnight.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Data.Contexts.Configurations
{
    public partial class PlayerAbilityConfiguration : IEntityTypeConfiguration<PlayerAbility>
    {
        public void Configure(EntityTypeBuilder<PlayerAbility> entity)
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.AbilityId, "IX_PlayerAbilities_AbiityId");

            entity.HasIndex(e => e.PlayerCharacterId, "IX_PlayerAbilities_PlayerCharacterId");

            entity.HasOne(d => d.Ability)
                .WithMany()
                .HasForeignKey(d => d.AbilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlayerAbilities_Abilities");

            entity.HasOne(d => d.PlayerCharacter)
                .WithMany()
                .HasForeignKey(d => d.PlayerCharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlayerAbilities_PlayerCharacters");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PlayerAbility> entity);
    }
}