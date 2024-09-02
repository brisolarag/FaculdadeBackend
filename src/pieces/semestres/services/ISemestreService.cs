using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.semestres.dtos;
using FaculdadeApp_Backend.src.pieces.semestres.models;

namespace FaculdadeApp_Backend.src.pieces.semestres.services;
public interface ISemestreService
{
    Task<Semestre> Create(SemestreRequest request);
    Task<List<SemestreDto>> Get();
}