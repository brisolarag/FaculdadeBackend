using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.Infrastructure.Database;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using FaculdadeApp_Backend.src.pieces.semestres.dtos;
using FaculdadeApp_Backend.src.pieces.semestres.models;
using Microsoft.EntityFrameworkCore;

namespace FaculdadeApp_Backend.src.pieces.semestres.repositories;
public class SemestreRepository : ISemestreRepository
{
    private readonly ApplicationContext _dbContext;
    public SemestreRepository(ApplicationContext dbContext) {this._dbContext = dbContext;}

    public async Task<Semestre> Create(SemestreRequest request)
    {
        Semestre newSemestre = new Semestre(request.Ano, request.Metade);
        _dbContext.Semestres.Add(newSemestre);
        await _dbContext.SaveChangesAsync();
        return newSemestre;
    }

    public async Task<List<Semestre>> Get()
    {
        return await _dbContext.Semestres.Include(s => s.Cadeiras).ToListAsync();
    }

}