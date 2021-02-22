using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCompras.Models;
using SistemaDeCompras.Services;

namespace SistemaDeCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly IArticuloService _articuloService;
        public ArticuloController(IArticuloService ArticuloService)
        {
            _articuloService = ArticuloService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Articuloes = _articuloService.GetAll().ToList();
            return Ok(Articuloes);
        }

        [HttpPost]
        public IActionResult Post(Articulo dto)
        {
            var result = _articuloService.Add(dto);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(Articulo dto)
        {
            var result = _articuloService.Update(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _articuloService.Delete(id);
            return Ok(result);
        }
    }
}
