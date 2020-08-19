using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using finalGroupProject.Models;

namespace finalGroupProject.Controllers
{
    public class CarSuppliesController : Controller
    {
        private readonly finalGroupProjectContext _context;

        public CarSuppliesController(finalGroupProjectContext context)
        {
            _context = context;
        }

        // GET: CarSupplies
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarSupply.ToListAsync());
        }

        // GET: CarSupplies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carSupply = await _context.CarSupply
                .FirstOrDefaultAsync(m => m.ID == id);
            if (carSupply == null)
            {
                return NotFound();
            }

            return View(carSupply);
        }

        // GET: CarSupplies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarSupplies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,fName,lName,address,city,state,zip,phone,userName,password")] CarSupply carSupply)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carSupply);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carSupply);
        }

        // GET: CarSupplies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carSupply = await _context.CarSupply.FindAsync(id);
            if (carSupply == null)
            {
                return NotFound();
            }
            return View(carSupply);
        }

        // POST: CarSupplies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,fName,lName,address,city,state,zip,phone,userName,password")] CarSupply carSupply)
        {
            if (id != carSupply.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carSupply);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarSupplyExists(carSupply.ID))
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
            return View(carSupply);
        }

        // GET: CarSupplies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carSupply = await _context.CarSupply
                .FirstOrDefaultAsync(m => m.ID == id);
            if (carSupply == null)
            {
                return NotFound();
            }

            return View(carSupply);
        }

        // POST: CarSupplies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carSupply = await _context.CarSupply.FindAsync(id);
            _context.CarSupply.Remove(carSupply);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarSupplyExists(int id)
        {
            return _context.CarSupply.Any(e => e.ID == id);
        }
    }
}
