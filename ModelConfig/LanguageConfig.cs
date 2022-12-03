using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToProgramming.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowToProgramming.ModelConfig
{
    public class LanguageConfig : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder
                .HasKey(l => l.LanguageId);
            
            builder
                .HasOne(l => l.LanguageFamily)
                .WithMany(lf => lf.Languages)
                .HasForeignKey(l => l.LanguageFamilyId)
                .IsRequired(true);


            builder
                .HasOne(l => l.LanguageLevel)
                .WithMany(ll => ll.Languages)
                .HasForeignKey(l => l.LanguageLevelId)
                .IsRequired();
                
            builder
                .HasOne(l => l.Typee)
                .WithMany(t => t.Language)
                .HasForeignKey(l => l.TypeeId)
                .IsRequired();        
                
                
            builder
                .HasOne(l => l.Creator)
                .WithMany(c => c.CLanguages)
                .HasForeignKey(l => l.CreatorId)
                .IsRequired();

            builder
                .HasMany(l => l.LParadigms)
                .WithMany(p => p.PLanguages)
                .UsingEntity<LanguageParadigm>(
                    lp =>
                        lp.HasOne(lp => lp.Paradigm)
                            .WithMany(l => l.JPlanguages)
                            .HasForeignKey(lp => lp.ParadigmId),
                    lp => 
                        lp.HasOne(lp => lp.Language)
                            .WithMany(l => l.JLParadigms)
                            .HasForeignKey(lp => lp.LanguageId),
                    lp => 
                        lp.HasKey(
                           lp => new {lp.LanguageId,lp.ParadigmId}
                        )
                );
        }
    }
}