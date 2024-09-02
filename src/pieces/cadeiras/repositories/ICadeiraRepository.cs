using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.repositories;
public interface ICadeiraRepository
{
    Task<Cadeira> Create(CadeiraRequest request);
    Task<List<Cadeira>> Get();
}