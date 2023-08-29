using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using api_pim.Entities;
using System.Net;
using api_pim.Exceptions;

namespace api_pim.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TipoPagamentoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    private readonly ILogger<TipoPagamentoController> _logger;

    public TipoPagamentoController(ApplicationDbContext context, ILogger<TipoPagamentoController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpPost]
    [Authorize]
    public IActionResult Create([FromBody] TipoPagamento request)
    {
        try
        {
            if (request == null)
            {
                return BadRequest(new { message = "Dados do tipo de pagamento inválidos." });
            }

            _context.TipoPagamento.Add(request);
            _context.SaveChanges();
            _logger.LogInformation("TipoPagamentoController.Get -> [Success]");

            return Ok($"Tipo de pagamento [{request.Valor}] criado com sucesso");
        }
        catch (Exception)
        {
            _logger.LogError("TipoPagamentoController.Create -> [Error]");
            throw new ApiException((int)HttpStatusCode.InternalServerError, $"Erro interno [{ErrorCode.CTP}]");
        }
    }
}