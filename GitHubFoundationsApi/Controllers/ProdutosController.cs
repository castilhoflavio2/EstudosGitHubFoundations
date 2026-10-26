using GitHubFoundationsApi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace GitHubFoundationsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(Name = "Produtos")]
        public IEnumerable<ProdutosDTO> Get()
        {
            var produtos = new List<ProdutosDTO>();
            var produto1 = new ProdutosDTO("Bola", 1, null);
            var produto2 = new ProdutosDTO("Leite", 5, DateOnly.MaxValue);
            var produto3 = new ProdutosDTO("Controle Remoto", 2, null);

            produtos.Add(produto1);
            produtos.Add(produto2);
            produtos.Add(produto3);

            return produtos;
        }
    }
}
