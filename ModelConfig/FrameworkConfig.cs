using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToProgramming.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowToProgramming.ModelConfig
{
    public class FrameworkConfig : IEntityTypeConfiguration<Framework>
    {
        public void Configure(EntityTypeBuilder<Framework> builder)
        {
            builder
                .HasKey(f => f.FrameWorkId);


            builder
                .HasMany(f => f.FLanguages)
                .WithMany(l => l.LFrameworks)
                .UsingEntity<LanguageFramework>(

                
                lf => 
                    lf.HasOne(lf => lf.Language)
                        .WithMany(l => l.JLFramework)
                        .HasForeignKey(lf => lf.FrameworkId),

                    lf => 
                        lf.HasOne(lf => lf.Framework)
                            .WithMany(f => f.JFLanguage)
                            .HasForeignKey(lf => lf.FrameworkId),
                    
                    lf => 
                        lf.HasKey(

                            lf => new {lf.LanguageId,lf.FrameworkId}
                        )
                );
        }
    }
}