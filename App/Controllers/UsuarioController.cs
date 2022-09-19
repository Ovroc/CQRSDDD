using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace App.Controllers
{
    [Route("api/Usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IActionResult> List(int quantidade)
        {
            var result = await _usuarioService.GetAll(quantidade);
            return Ok(result.ToList());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _usuarioService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RequestUsuarioViewModel usuarioViewModel)
        {
            var result = await _usuarioService.Register(usuarioViewModel);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] RequestUsuarioViewModel usuarioViewModel)
        {
            var result = await _usuarioService.Update(usuarioViewModel);

            if (result == null)
                return BadRequest();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _usuarioService.Remove(id);
            return Ok(result);
        }
    }
}
