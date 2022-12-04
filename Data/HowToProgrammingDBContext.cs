using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToProgramming.ModelConfig;
using HowToProgramming.Models;
using Microsoft.EntityFrameworkCore;

namespace HowToProgramming.Data
{
    public class HowToProgrammingDBContext : DbContext
    {
        public HowToProgrammingDBContext(DbContextOptions<HowToProgrammingDBContext> options) : base(options)
        {
        }

        DbSet<Creator> Creators {get;set;}
        DbSet<Framework> FrameWorks {get;set;}
        DbSet<Gender> Genders {get;set;}
        DbSet<Language> Languages {get;set;}
        DbSet<LanguageFamily> LanguageFamilies {get;set;}
        DbSet<LanguageLevel> LanguageLevel {get;set;}
        DbSet<Paradigm> Paradigms {get;set;}
        DbSet<Typee> Typees {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            new CreatorConfig().Configure(modelBuilder.Entity<Creator>());
            new LanguageConfig().Configure(modelBuilder.Entity<Language>());
            new FrameworkConfig().Configure(modelBuilder.Entity<Framework>());
        }
    }
}