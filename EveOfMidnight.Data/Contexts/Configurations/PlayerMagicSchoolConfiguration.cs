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
    public partial class PlayerMagicSchoolConfiguration : IEntityTypeConfiguration<PlayerMagicSchool>
    {
        public void Configure(EntityTypeBuilder<PlayerMagicSchool> entity)
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.MagicSchoolId, "IX_PlayerMagicSchools_MagicSchoolId");

            entity.HasIndex(e => e.PlayerCharacterId, "IX_PlayerMagicSchools_PlayerCharacterId");

            entity.HasOne(d => d.MagicSchool)
                .WithMany()
                .HasForeignKey(d => d.MagicSchoolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlayerMagicSchools_MagicSchool");

            entity.HasOne(d => d.PlayerCharacter)
                .WithMany()
                .HasForeignKey(d => d.PlayerCharacterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PlayerMagicSchools_PlayerCharacters");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<PlayerMagicSchool> entity);
    }
}