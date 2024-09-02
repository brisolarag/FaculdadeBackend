using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.semestres.dtos;
using FaculdadeApp_Backend.src.pieces.semestres.models;

namespace FaculdadeApp_Backend.src.pieces.semestres.repositories;
public interface ISemestreRepository
{
    Task<Semestre> Create(SemestreRequest request);
    Task<List<Semestre>> Get();
}