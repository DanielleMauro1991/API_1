using Chapter.WebApi.Models;
using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Chapter.WebApi.Controllers{
    [Route("api/[controller]")]
    [ApiController]

    public class LivrosController : ControllerBase{
        private readonly LivroRepository _livroRepository;
        public LivrosController (LivroRepository livroRepository){
            _livroRepository = livroRepository;
        }
        [HttpGet]
        public IActionResult Listar(){
            return Ok (_livroRepository.Listar());
        }
        }
    }

