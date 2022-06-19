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
    public class CoffeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoffeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Coffees/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        // POST: Coffees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description,Price")] Coffee coffee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coffee);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            return View(coffee);
        }





        // GET: Coffees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Coffee.ToListAsync());
        }



    }
}
