﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

namespace EveOfMidnight.Data.Contexts
{
    public partial class EveofmidnightContext : DbContext
    {
        public EveofmidnightContext(DbContextOptions<EveofmidnightContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<AbilityLevel> AbilityLevels { get; set; }
        public virtual DbSet<Beastiary> Beastiaries { get; set; }
        public virtual DbSet<Bound> Bounds { get; set; }
        public virtual DbSet<CharacterDetail> CharacterDetails { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<DamageType> DamageTypes { get; set; }
        public virtual DbSet<Diseas> Diseases { get; set; }
        public virtual DbSet<Fate> Fates { get; set; }
        public virtual DbSet<Focus> Focuss { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemSubType> ItemSubTypes { get; set; }
        public virtual DbSet<ItemType> ItemTypes { get; set; }
        public virtual DbSet<MagicSchool> MagicSchools { get; set; }
        public virtual DbSet<Metal> Metals { get; set; }
        public virtual DbSet<PlayerAbility> PlayerAbilities { get; set; }
        public virtual DbSet<PlayerCharacter> PlayerCharacters { get; set; }
        public virtual DbSet<PlayerMagicSchool> PlayerMagicSchools { get; set; }
        public virtual DbSet<PlayerSkill> PlayerSkills { get; set; }
        public virtual DbSet<PlayerSpell> PlayerSpells { get; set; }
        public virtual DbSet<PlayerTrait> PlayerTraits { get; set; }
        public virtual DbSet<Race> Races { get; set; }
        public virtual DbSet<RaceSkill> RaceSkills { get; set; }
        public virtual DbSet<RaceTrait> RaceTraits { get; set; }
        public virtual DbSet<Rarity> Rarities { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Spell> Spells { get; set; }
        public virtual DbSet<SpellRank> SpellRanks { get; set; }
        public virtual DbSet<StatusEffect> StatusEffects { get; set; }
        public virtual DbSet<Trait> Traits { get; set; }
        public virtual DbSet<TraitCategory> TraitCategories { get; set; }
        public virtual DbSet<Wood> Woods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configurations.AbilityConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.AbilityLevelConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.BeastiaryConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.BoundConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.CharacterDetailConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ClassConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ComponentConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.DamageTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.DiseasConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.FateConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.FocusConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.FoodConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ItemConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ItemSubTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.ItemTypeConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.MagicSchoolConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.MetalConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PlayerAbilityConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PlayerCharacterConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PlayerMagicSchoolConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PlayerSkillConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PlayerSpellConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.PlayerTraitConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RaceConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RaceSkillConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RaceTraitConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.RarityConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SkillConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SpellConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.SpellRankConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.StatusEffectConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.TraitConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.TraitCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new Configurations.WoodConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
