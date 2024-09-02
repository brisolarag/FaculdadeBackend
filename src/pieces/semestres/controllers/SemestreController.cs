using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.semestres.dtos;
using FaculdadeApp_Backend.src.pieces.semestres.models;
using FaculdadeApp_Backend.src.pieces.semestres.services;
using Microsoft.AspNetCore.Mvc;

namespace FaculdadeApp_Backend.src.Controllers;
[ApiController]
[Route("[controller]")]
public class SemestreController : ControllerBase
{
    private readonly ISemestreService _service;
    public SemestreController(ISemestreService service) {this._service = service;}

    [HttpPost]
    public async Task<ActionResult<Semestre>> Create(SemestreRequest request) {
        try {
            var created = await _service.Create(request);
            return Ok(new {err = false, data = created});
        } catch {
            return BadRequest(new {err = true});
        }
    }

    [HttpGet]
    public async Task<ActionResult<List<SemestreDto>>> Get() {
        try {
            var sems = await _service.Get();
            return Ok(new {err=false, data= sems});
        } catch {
            return BadRequest(new {err=true});
        }
    } 
}