using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using FaculdadeApp_Backend.src.pieces.semestres.models;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
public class CadeiraDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public int QtdAulas { get; set; }
    public int Creditos { get; set; }
    public int PodeFaltar { get; set; }
    public int SemestreId { get; set; }


    public static CadeiraDto ParseModel(Cadeira model) {
        CadeiraDto parsed = new CadeiraDto {
            Id = model.Id,
            Nome = model.Nome,
            QtdAulas = model.QtdAulas,
            Creditos = model.Creditos,
            PodeFaltar = model.PodeFaltar,
            SemestreId = model.Semestre.Id
        };
        return parsed;
    }
}