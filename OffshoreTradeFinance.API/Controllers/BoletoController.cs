using Microsoft.AspNetCore.Mvc;
using OffshoreTradeFinance.Domain.Interfaces.Services;

namespace OffshoreTradeFinance.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoletoController : ControllerBase
    {
        private readonly IBoletoService _boletoService;

        public BoletoController(IBoletoService boletoService)
        {
            _boletoService = boletoService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBoleto(int id)
        {
            var boleto = await _boletoService.GetBoletoByIdAsync(id);
            if (boleto is null)
            {
                return NotFound();
            }

            return Ok(boleto);
        }
    }
}
