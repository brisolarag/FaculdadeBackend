using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.semestres.dtos;
using FaculdadeApp_Backend.src.pieces.semestres.models;
using FaculdadeApp_Backend.src.pieces.semestres.repositories;

namespace FaculdadeApp_Backend.src.pieces.semestres.services;
public class SemestreService : ISemestreService
{
    private readonly ISemestreRepository _repository;


    public SemestreService(ISemestreRepository repository) {this._repository = repository;}

    public async Task<Semestre> Create(SemestreRequest request)
    {
        return await _repository.Create(request);
    }

    public async Task<List<SemestreDto>> Get()
    {
        var query = await _repository.Get();
        var parsed = query.Select(SemestreDto.ParseModel).ToList();
        return parsed;
    }
}