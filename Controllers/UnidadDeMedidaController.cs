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
    public class UnidadDeMedidaController : ControllerBase
    {
        private readonly IUnidadDeMedidaService _unidadDeMedidaService;
        public UnidadDeMedidaController(IUnidadDeMedidaService UnidadDeMedidaService)
        {
            _unidadDeMedidaService = UnidadDeMedidaService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var UnidadDeMedidaes = _unidadDeMedidaService.GetAll().ToList();
            return Ok(UnidadDeMedidaes);
        }

        [HttpPost]
        public IActionResult Post(UnidadDeMedida dto)
        {
            var result = _unidadDeMedidaService.Add(dto);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(UnidadDeMedida dto)
        {
            var result = _unidadDeMedidaService.Update(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _unidadDeMedidaService.Delete(id);
            return Ok(result);
        }
    }
}
