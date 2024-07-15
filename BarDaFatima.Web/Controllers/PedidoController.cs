using BarDaFatima.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarDaFatima.Web.Controllers;

public class PedidoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("pedido")]
    public IActionResult GerarPedido()
    {
          
    }

    [HttpGet("produtos")]

    public IActionResult ConsultarProdutos()
    {
        return PartialView("_listagem-produtos", new List<Produto>() );
    }


    [HttpGet("pedido/{numeroPedido}")]
    public IActionResult ConsultarPedido(Int64 numeroPedido) => StatusCode(200, new Pedido());

    [HttpPost("pedido/{numeroPedido}/item")]
    public IActionResult IncluirPedido(Int64 numeroPedido, [FromBody] ItemPedido itemPedido) => StatusCode(200, new Pedido());


    [HttpDelete("pedido/{numeroPedido}/item/{codigoItem}")]
    public IActionResult RemoverItemPedido(Int64 numeroPedido , Int64 codigoItem) => StatusCode(200, new Pedido());

    [HttpGet("pedido/{numeroPedido}/listar")]
    public IActionResult ListarItemPedido(Int64 numeroPedido) => StatusCode(200, new Pedido());


    [HttpPatch("pedido/{numeroPedido}/item/{codigoItem}/{quantidade}")]
    public IActionResult AlterarItemPedido(Int64 numeroPedido, Int64 codigoItem, int quantidade, [FromBody] ItemPedido itemPedido) => StatusCode(200, new Pedido());



   

    [HttpPatch("conta/{numeroPedido}")]
    public IActionResult FecharConta(Int64 numeroPedido) => StatusCode(200, new Pedido());



}
