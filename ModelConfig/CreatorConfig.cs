using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HowToProgramming.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HowToProgramming.ModelConfig;

public class CreatorConfig : IEntityTypeConfiguration<Creator>
{
    public void Configure(EntityTypeBuilder<Creator> builder)
    {
        builder
            .HasKey(c => c.CreatorId);

        builder
            .HasMany(c => c.CLanguages)
            .WithOne(l => l.Creator)
            .HasForeignKey(c => c.LanguageId)
            .IsRequired();

        builder
            .HasMany(c => c.CFrameworks)
            .WithOne(fr => fr.Creator)
            .HasForeignKey(c => c.FrameWorkId);

        builder
            .HasOne(c => c.Gender)
            .WithMany(g => g.Creator)
            .HasForeignKey(c => c.GenderId)
            .IsRequired();

        // builder
        // .Property(c => c.DOB)
        // .

    }
}
