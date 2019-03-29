using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacadeWebApi.System.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Facade.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacaoMatematicaController : ControllerBase
    {
        private readonly IFacadeOperacaoMatematica _facadeOperacao;

        public OperacaoMatematicaController(IFacadeOperacaoMatematica facade)
        {
            this._facadeOperacao = facade;
        }

        // GET api/OperacaoMatematica/multiplicar/1/2
        [HttpGet("Multiplicar/{multA}/{multB}", Name = "Multiplicar")]
        public IActionResult Multiplicar(string multA, string multB)
        {
            double valor= _facadeOperacao.Multiplicar(Convert.ToDouble(multA), Convert.ToDouble(multB));

            return Ok(valor);
        }

        // GET api/OperacaoMatematica/Dividir/1/2
        [HttpGet("Dividir/{divA}/{divB}", Name = "Dividir")]
        public IActionResult Dividir(string divA, string divB)
        {
            return Ok(_facadeOperacao.Dividir(Convert.ToDouble(divA), Convert.ToDouble(divB)));
        }


        [HttpGet("Somar/{somaA}/{somaB}", Name = "Somar")]
        public IActionResult Somar(string somaA, string somaB)
        {
            return Ok(_facadeOperacao.Somar(Convert.ToDouble(somaA), Convert.ToDouble(somaB)));
        }


        [HttpGet("Subtrair/{subA}/{subB}", Name = "Subtrair")]
        public IActionResult Subtrair(string subA, string subB)
        {
            return Ok(_facadeOperacao.Subtrair(Convert.ToDouble(subA), Convert.ToDouble(subB)));
        }
    }
}