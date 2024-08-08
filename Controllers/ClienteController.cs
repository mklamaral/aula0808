using Microsoft.AspNetCore.Mvc;
using ExercicioGitHubMarqueto.Data;

namespace ExercicioGitHubMarqueto.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AulaContext _context;

        public ClienteController(AulaContext context) 
        {
            _context = context;
        }
        public IActionResult CadastroCliente()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CadastroCliente([Bind("Id,Nome,RG,CPF,Usuario,Senha,CEP,UF,Cidade,Bairro,Rua,Numero,Complemento")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("BuscaCliente");
            }
            return View(cliente);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
