using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;

namespace FaculdadeApp_Backend.src.pieces.semestres.models;
public class Semestre
{
    public int Id { get; set; } 
    public int Ano { get; set; }
    public int Metade { get; set; }
    public string Descricao { get; set; }

    
    public Semestre(int ano, int metade) {
        this.Ano = ano;
        this.Metade = metade;
        this.Descricao = $"{this.Ano}/{this.Metade}";
    }

    public List<Cadeira> Cadeiras { get; set; } = new();
}