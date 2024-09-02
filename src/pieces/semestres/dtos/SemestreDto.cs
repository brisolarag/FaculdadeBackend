using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
using FaculdadeApp_Backend.src.pieces.semestres.models;

namespace FaculdadeApp_Backend.src.pieces.semestres.dtos;
public class SemestreDto
{
    public int Id { get; set; }   
    public string Descricao { get; set; } = null!;
    public List<CadeiraDto>? Cadeiras { get; set; }

    public static SemestreDto ParseModel(Semestre model) {
        return new SemestreDto {
            Id = model.Id,
            Descricao = model.Descricao,
            Cadeiras = model.Cadeiras.Select(CadeiraDto.ParseModel).ToList()
        };
    }
}