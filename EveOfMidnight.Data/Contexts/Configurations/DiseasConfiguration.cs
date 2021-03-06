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
    public partial class DiseasConfiguration : IEntityTypeConfiguration<Diseas>
    {
        public void Configure(EntityTypeBuilder<Diseas> entity)
        {
            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(e => e.Effect)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Diseas> entity);
    }
}
