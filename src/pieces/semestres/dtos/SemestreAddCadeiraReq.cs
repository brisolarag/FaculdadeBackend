using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaculdadeApp_Backend.src.pieces.semestres.dtos;
public class SemestreAddCadeiraReq
{
    [Required]
    public string SemestreId { get; set; } = null!;
    public int CadeiraId { get; set; }
}