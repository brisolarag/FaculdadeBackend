using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.semestres.models;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.models;
public class Cadeira
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public int QtdAulas { get; set; }
    public int Creditos { get; set; }
    public int PodeFaltar { get; set; }

    public Semestre Semestre { get; set; } = null!;


}