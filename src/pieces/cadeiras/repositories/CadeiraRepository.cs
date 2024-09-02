using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.Infrastructure.Database;
using FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.repositories;
public class CadeiraRepository : ICadeiraRepository
{
    private readonly ApplicationContext _dbContext;
    public CadeiraRepository(ApplicationContext dbContext) {this._dbContext = dbContext;}

    public async Task<Cadeira> Create(CadeiraRequest request)
    {
        var semestre = await _dbContext.Semestres.FindAsync(request.SemestreId);
        if (semestre == null)
            throw new Exception();

        Cadeira newCadeira = new Cadeira {
            Nome = request.Nome,
            Semestre = semestre
        };
        _dbContext.Cadeiras.Add(newCadeira);
        await _dbContext.SaveChangesAsync();
        return newCadeira;
    }

    public async Task<List<Cadeira>> Get() {
        return await _dbContext.Cadeiras.Include(c => c.Semestre).ToListAsync();
    }

}