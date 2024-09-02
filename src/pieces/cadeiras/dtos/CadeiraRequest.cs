using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
public class CadeiraRequest
{
    [Required]
    [MaxLength(255)]
    public string Nome { get; set; } = null!;
    [Required]
    public int SemestreId { get; set; }
}
