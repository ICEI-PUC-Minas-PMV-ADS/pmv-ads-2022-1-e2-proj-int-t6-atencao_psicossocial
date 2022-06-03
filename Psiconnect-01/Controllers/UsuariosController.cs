using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Psiconnect_01.Models;
using System.Net.Http;

namespace Psiconnect_01.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private static Random random = new Random();
        private List<RedefinicaoSenhaUsuario> listaRedefinicoesEmAberto = new List<RedefinicaoSenhaUsuario>();


        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }


        public ActionResult IndexMeusDados()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userName = User.Identity.Name;
                var usuario = _context.Usuarios.FirstOrDefault(x => x.Nome == userName);

                if (usuario != null)
                    return View(usuario);
            }

            return RedirectToAction("Index");
        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login([Bind("Cpf,Senha")] Usuario usuarios)
        {
            var user = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Cpf == usuarios.Cpf);
            if (user == null)
            {
                ViewBag.Message = "Usuario e ou Senha inválidos ";
                return View();
            }
            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(usuarios.Senha, user.Senha);
            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                    new Claim(ClaimTypes.Role, user.Perfil.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(1),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/Home/Index");
            }

            ViewBag.Message = "Usuario e ou Senha inválidos ";
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Usuarios");
        }


        public IActionResult AccessDenid()
        {
            return View();
        }







        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Cpf == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Cpf,Email,Senha,Perfil")] Usuario usuario)
        {
            if (_context.Usuarios.Any(c => c.Cpf == usuario.Cpf))
            {
                ModelState.AddModelError("CPF", $"Esse CPF já está registrado.");
            }

            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
          
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Nome,Cpf,Email,Senha,Perfil")] Usuario usuario)
        {
            if (id != usuario.Cpf)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Cpf))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexMeusDados));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Cpf == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> VerificaUsuarioExistente(string cpf)
        {
            if (UsuarioExists(cpf))
                return Ok();
            else
                return BadRequest();
            
        }

        [HttpGet]
        public async Task<IActionResult> EnviaTokenParaUsuario(string cpf)
        {
            var token = RandomString(10);
            // Envia email ou outra f
            var redef = new RedefinicaoSenhaUsuario();
            redef.cpf = cpf;
            redef.token = token;

            listaRedefinicoesEmAberto.Add(redef);
            Console.WriteLine(token);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> VerificaTokenDigitado([FromBody] RedefinicaoSenhaUsuario redefinicaoSenhaUsuario)
        {
            var redef = listaRedefinicoesEmAberto.Where(x => x.cpf == redefinicaoSenhaUsuario.cpf && x.token == redefinicaoSenhaUsuario.token);
            if (redef != null && redef.Count() > 0)
            {
                return Ok();
            }
            else
                return BadRequest();


        }

        [HttpPost]
        public async Task<IActionResult> RedefineSenha([FromBody] RedefinicaoSenhaUsuario redefinicaoRecebida)
        {
            var redef = listaRedefinicoesEmAberto.Where(x => x.cpf == redefinicaoRecebida.cpf && x.token == redefinicaoRecebida.token);
            if (redef != null && redef.Count() > 0)
            {
                var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Cpf == redefinicaoRecebida.cpf);

                if (usuario == null)
                    return BadRequest();

                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(redefinicaoRecebida.senhaNova);
                _context.Update(usuario);
                await _context.SaveChangesAsync();


                listaRedefinicoesEmAberto.RemoveAll(x => x.cpf == redefinicaoRecebida.cpf);
                return Ok();
            }
            else
                return BadRequest();
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private bool UsuarioExists(string id)
        {
            return _context.Usuarios.Any(e => e.Cpf == id);
        }
    }
}
