using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculaJurosController : ControllerBase
{


    private IMapper _mapper;

    public CalculaJurosController(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// Calcula a taxa de Juros com 1%
    /// </summary>
    /// <returns>IActionResult</returns>



    [HttpGet("/calculajuros/{valorinicial},{meses}")]
    public IActionResult calculajuros(double valorinicial, int meses)
    {
        if (valorinicial == 0 || meses == 0)
        {
            return Ok("Parametros Incorretos");
        }
        else
        {
            var valorfinal = Math.Round(valorinicial * Math.Pow(1+ 0.01, meses),2);
            return Ok(valorfinal);
        }
        
        
    }


    [HttpGet("/showmethecode")]
    public IActionResult showmethecode()
    {
            return Ok("https://github.com/lipe19941/APIJuros/");

    }


}
        