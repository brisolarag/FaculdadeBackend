using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.services;
public interface ICadeiraService
{
    Task<Cadeira> Create(CadeiraRequest request);
    Task<List<CadeiraDto>> Get();
}