using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaculdadeApp_Backend.src.pieces.cadeiras.dtos;
using FaculdadeApp_Backend.src.pieces.cadeiras.models;
using FaculdadeApp_Backend.src.pieces.cadeiras.services;
using Microsoft.AspNetCore.Mvc;

namespace FaculdadeApp_Backend.src.pieces.cadeiras.controllers;
[ApiController]
[Route("[controller]")]
public class CadeiraController : ControllerBase
{
    private readonly ICadeiraService _service;
    public CadeiraController(ICadeiraService service) {this._service = service;}


    [HttpGet]
    public async Task<ActionResult<List<CadeiraDto>>> Get() {
        try {
            var cadeiras = await _service.Get();
            return Ok(new {err=false,data=cadeiras});
        } catch {
            return BadRequest();
        }
    }

    [HttpPost]
    public async Task<ActionResult<Cadeira>> Create(CadeiraRequest request) {
        try {
            var created = await _service.Create(request);
            return Ok(new {err = false, data = created});
        } catch {
            return BadRequest();
        }
    }

}