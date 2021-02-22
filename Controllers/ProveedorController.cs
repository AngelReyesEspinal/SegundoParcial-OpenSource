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
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorService _proveedorService;
        public ProveedorController(IProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var proveedores = _proveedorService.GetAll().ToList();
            return Ok(proveedores);
        }

        [HttpPost]
        public IActionResult Post(Proveedor dto)
        {
            var result = _proveedorService.Add(dto);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(Proveedor dto)
        {
            var result = _proveedorService.Update(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _proveedorService.Delete(id);
            return Ok(result);
        }
    }
}
