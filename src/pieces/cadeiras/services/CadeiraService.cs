using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using FaculdadeApp_Backend.src.pieces.cadeiras.repositories;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.services;
public class CadeiraService : ICadeiraService
{
    private readonly ICadeiraRepository _repository;
    public CadeiraService(ICadeiraRepository repository) {this._repository = repository;}

    public async Task<Cadeira> Create(CadeiraRequest request)
    {
        return await _repository.Create(request);
    }

    public async Task<List<CadeiraDto>> Get()
    {
        var query = await _repository.Get();
        var dtos = query.Select(CadeiraDto.ParseModel).ToList();
        return dtos;
    }
}