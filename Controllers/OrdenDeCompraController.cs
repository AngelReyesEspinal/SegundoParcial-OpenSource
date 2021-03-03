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
    public class OrdenDeCompraController : ControllerBase
    {
        private readonly IOrdenDeCompraService _ordenDeCompraService;
        public OrdenDeCompraController(IOrdenDeCompraService OrdenDeCompraService)
        {
            _ordenDeCompraService = OrdenDeCompraService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var OrdenDeCompras = _ordenDeCompraService.GetAll().ToList();
            return Ok(OrdenDeCompras);
        }

        [HttpPost]
        public IActionResult Post(OrdenDeCompra dto)
        {
            var result = _ordenDeCompraService.Add(dto);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(OrdenDeCompra dto)
        {
            var result = _ordenDeCompraService.Update(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _ordenDeCompraService.Delete(id);
            return Ok(result);
        }

        [HttpGet("GetOrdersByDepartmentOrProvider")]
        public IActionResult GetOrdersByDepartmentOrProvider([FromQuery] int? departamentoId, [FromQuery] int? proveedorId)
        {
            var OrdenDeCompras = _ordenDeCompraService.GetOrdenByDepartamento(departamentoId, proveedorId).ToList();
            return Ok(OrdenDeCompras);
        }
    }
}
