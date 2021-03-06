// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using EveOfMidnight.Data.Contexts;
using EveOfMidnight.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace EveOfMidnight.Data.Contexts.Configurations
{
    public partial class FocusConfiguration : IEntityTypeConfiguration<Focus>
    {
        public void Configure(EntityTypeBuilder<Focus> entity)
        {
            entity.ToTable("Focus");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000);

            entity.Property(e => e.IconName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Focus> entity);
    }
}
