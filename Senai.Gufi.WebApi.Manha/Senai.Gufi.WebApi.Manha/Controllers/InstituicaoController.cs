using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Gufi.WebApi.Manha.Domains;
using Senai.Gufi.WebApi.Manha.Interfaces;
using Senai.Gufi.WebApi.Manha.Repositories;

namespace Senai.Gufi.WebApi.Manha.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class InstituicaoController : ControllerBase
    {
        private IInstituicaoRepository _institucaoRepository { get; set; }


        public InstituicaoController()
        {
            _institucaoRepository = new InstituicaoRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_institucaoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_institucaoRepository.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Post(Instituicao novaIT)
        {
            _institucaoRepository.Cadastrar(novaIT);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Instituicao tipoInstituicaoAtualizada)
        {
            try
            {
                _institucaoRepository.Atualizar(id, tipoInstituicaoAtualizada);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _institucaoRepository.Deletar(id);

            return StatusCode(204);
        }

    }
}