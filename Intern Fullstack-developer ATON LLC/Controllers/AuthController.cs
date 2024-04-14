using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Intern_Fullstack_developer_ATON_LLC_Domain;
using Intern_Fullstack_developer_ATON_LLC_Web.ViewModels;

namespace Intern_Fullstack_developer_ATON_LLC_Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly FullStackContext _context;

        public AuthController(FullStackContext context)
        {
            _context = context;
        }

        // GET: /Auth/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Auth/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Неверные учетные данные.");
                return View(model);
            }
            return RedirectToAction("Clients", new { userId = user.Id });
        }

        // GET: /Auth/Clients
        public async Task<IActionResult> Clients(int userId)
        {
            var clients = await _context.Clients
                .Include(c => c.ResponsiblePerson)
                .Where(c => c.ResponsiblePersonId == userId)
                .ToListAsync();

            if (clients == null)
            {
                return NotFound();
            }

            return View(clients);
        }

        // POST: /Auth/ChangeStatus
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeStatus(ChangeStatusViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Clients", new { userId = model.UserId });
            }

            var client = await _context.Clients.Include(c => c.ResponsiblePerson).FirstOrDefaultAsync(c => c.Id == model.ClientId);
            if (client == null)
            {
                return NotFound();
            }

            client.Status = model.Status;
            _context.Update(client);
            await _context.SaveChangesAsync();

            return RedirectToAction("Clients", new { userId = client.ResponsiblePerson.Id });
        }
    }
}
