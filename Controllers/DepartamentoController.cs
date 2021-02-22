using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeCompras.Models;
using SistemaDeCompras.Services.Departamento;

namespace SistemaDeCompras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly IDepartamentoService _departamentoService;
        public DepartamentoController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var departamentos = _departamentoService.GetAll().ToList();
            return Ok(departamentos);
        }

        [HttpPost]
        public IActionResult Post(Departamento dto)
        {
            var result = _departamentoService.Add(dto);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put(Departamento dto)
        {
            var result = _departamentoService.Update(dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _departamentoService.Delete(id);
            return Ok(result);
        }
    }
}
