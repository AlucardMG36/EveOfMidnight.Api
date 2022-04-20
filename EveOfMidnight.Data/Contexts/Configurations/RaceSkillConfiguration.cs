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
    public partial class RaceSkillConfiguration : IEntityTypeConfiguration<RaceSkill>
    {
        public void Configure(EntityTypeBuilder<RaceSkill> entity)
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.RaceId, "IX_RaceSkills_RaceId");

            entity.HasIndex(e => e.SkillId, "IX_RaceSkills_SkillId");

            entity.HasOne(d => d.Race)
                .WithMany()
                .HasForeignKey(d => d.RaceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceSkills_Races");

            entity.HasOne(d => d.Skill)
                .WithMany()
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RaceSkills_Skills");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<RaceSkill> entity);
    }
}
