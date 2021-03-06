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
    public partial class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> entity)
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(e => e.Duration).HasDefaultValueSql("((1))");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(25);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Food> entity);
    }
}
