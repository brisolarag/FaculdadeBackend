using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using FaculdadeApp_Backend.src.pieces.semestres.models;
using Microsoft.EntityFrameworkCore;

namespace FaculdadeApp_Backend.src.Infrastructure.Database.Relations;
public static class AppRelations
{
    public static void SetUpRelations(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Semestre>(entity => {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Ano).IsRequired();
            entity.Property(e => e.Metade).IsRequired();
            entity.HasMany(e => e.Cadeiras).WithOne(e => e.Semestre).OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Cadeira>(entity => {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
        });
    }
}