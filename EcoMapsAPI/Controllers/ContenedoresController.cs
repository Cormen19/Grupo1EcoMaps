﻿using EcoMapsAPI.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcoMapsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContenedoresController : ControllerBase
    {
        private readonly EcoMapsContext _context;
        public ContenedoresController(EcoMapsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContResiduo>>> GetAllContenedoresVidrio()
        {
            var allContenedores = await _context.ContResiduos.Where(c => c.Category.Contains("Vidrio")).Select(c => new
            {
                c.Category,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("Papel")]
        public async Task<ActionResult<IEnumerable<ContResiduo>>> GetAllContenedoresPapel()
        {
            var allContenedores = await _context.ContResiduos.Where(c => c.Category.Contains("Papel")).Select(c => new
            {
                c.Category,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("Envases")]
        public async Task<ActionResult<IEnumerable<ContResiduo>>> GetAllContenedoresEnvases()
        {
            var allContenedores = await _context.ContResiduos.Where(c => c.Category.Contains("Envases")).Select(c => new
            {
                c.Category,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("Ropa")]
        public async Task<ActionResult<IEnumerable<ContResiduo>>> GetAllContenedoresRopa()
        {
            var allContenedores = await _context.ContResiduos.Where(c => c.Category.Contains("Ropa")).Select(c => new
            {
                c.Category,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("Aceite")]
        public async Task<ActionResult<IEnumerable<ContResiduo>>> GetAllContenedoresAceite()
        {
            var allContenedores = await _context.ContResiduos.Where(c => c.Category.Contains("Aceite")).Select(c => new
            {
                c.Category,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("Eolicas")]
        public async Task<ActionResult<IEnumerable<Eolica>>> GetAllEolicas()
        {
            var allContenedores = await _context.Eolicas.Select(c => new
            {
                c.Nombre,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("CochesElec")]
        public async Task<ActionResult<IEnumerable<CocheElec>>> GetAllCochesE()
        {
            var allContenedores = await _context.CocheElecs.Select(c => new
            {
                c.Titular,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }

        [HttpGet("PuntosMovil")]
        public async Task<ActionResult<IEnumerable<CocheElec>>> GetAllPuntosMovil()
        {
            var allContenedores = await _context.PuntosMoviles.Select(c => new
            {
                c.Ubicacion,
                c.Lat,
                c.Lon
            }).ToListAsync();
            return Ok(allContenedores);
        }
        [HttpGet("Bilbogarbi")]
        public async Task<ActionResult<IEnumerable<Bilbogarbi>>> GetAllBilbogarbi()
        {
            var allContenedores = await _context.Bilbogarbis.Select(c => new
            {
                c.Name,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }
    }
}