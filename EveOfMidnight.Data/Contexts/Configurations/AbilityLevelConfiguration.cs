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
    public partial class AbilityLevelConfiguration : IEntityTypeConfiguration<AbilityLevel>
    {
        public void Configure(EntityTypeBuilder<AbilityLevel> entity)
        {
            entity.ToTable("AbilityLevel");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000);

            entity.Property(e => e.DotsToDice).HasDefaultValueSql("((1))");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<AbilityLevel> entity);
    }
}
