using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PavlyukFinalProjectForCSI350.Data;
using PavlyukFinalProjectForCSI350.Models;

namespace PavlyukFinalProjectForCSI350.Controllers
{
    public class SignUpResponcesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SignUpResponcesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SignUpResponces
        public async Task<IActionResult> Index()
        {
            return View(await _context.SignUpResponces.ToListAsync());
        }

        // GET: SignUpResponces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUpResponces = await _context.SignUpResponces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signUpResponces == null)
            {
                return NotFound();
            }

            return View(signUpResponces);
        }

        // GET: SignUpResponces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SignUpResponces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Phone,Age,message")] SignUpResponces signUpResponces)
        {
            if (ModelState.IsValid)
            {
                _context.Add(signUpResponces);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(signUpResponces);
        }

        // GET: SignUpResponces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUpResponces = await _context.SignUpResponces.FindAsync(id);
            if (signUpResponces == null)
            {
                return NotFound();
            }
            return View(signUpResponces);
        }

        // POST: SignUpResponces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Email,Phone,Age,message")] SignUpResponces signUpResponces)
        {
            if (id != signUpResponces.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(signUpResponces);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SignUpResponcesExists(signUpResponces.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(signUpResponces);
        }

        // GET: SignUpResponces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var signUpResponces = await _context.SignUpResponces
                .FirstOrDefaultAsync(m => m.Id == id);
            if (signUpResponces == null)
            {
                return NotFound();
            }

            return View(signUpResponces);
        }

        // POST: SignUpResponces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var signUpResponces = await _context.SignUpResponces.FindAsync(id);
            _context.SignUpResponces.Remove(signUpResponces);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SignUpResponcesExists(int id)
        {
            return _context.SignUpResponces.Any(e => e.Id == id);
        }
    }
}
