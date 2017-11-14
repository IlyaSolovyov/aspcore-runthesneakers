using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RunTheSneakers.Models;

namespace RunTheSneakers.Areas.Admin.Controllers
{

    public class ModelsController : BaseAdminController
    {
        private readonly DatabaseContext _context;

        public ModelsController(DatabaseContext context)
        {
            _context = context;    
        }

        // GET: Admin/Models
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Models.Include(m => m.Brand);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Admin/Models/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Models
                .Include(m => m.Brand)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // GET: Admin/Models/Create
        public IActionResult Create()
        {
            ViewData["Brand"] = new SelectList(_context.Brands, "Id", "Name");
            return View();
        }

        // POST: Admin/Models/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,BrandId")] Model model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["Brand"] = new SelectList(_context.Brands, "Id", "Name", model.BrandId);
            return View(model);
        }

        // GET: Admin/Models/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Models.SingleOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            ViewData["Brand"] = new SelectList(_context.Brands, "Id", "Name", model.BrandId);
            return View(model);
        }

        // POST: Admin/Models/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,BrandId")] Model model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModelExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["Brand"] = new SelectList(_context.Brands, "Id", "Name", model.BrandId);
            return View(model);
        }

        // GET: Admin/Models/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var model = await _context.Models
                .Include(m => m.Brand)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        // POST: Admin/Models/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var model = await _context.Models.SingleOrDefaultAsync(m => m.Id == id);
            _context.Models.Remove(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ModelExists(int id)
        {
            return _context.Models.Any(e => e.Id == id);
        }
    }
}
