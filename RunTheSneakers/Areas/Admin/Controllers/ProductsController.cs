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
    public class ProductsController : BaseAdminController
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;    
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var databaseContext = _context.Product.Include(p => p.Gender).Include(p => p.Material).Include(p => p.Model);
            return View(await databaseContext.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Gender)
                .Include(p => p.Material)
                .Include(p => p.Model)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name");
            ViewData["MaterialId"] = new SelectList(_context.Materials, "Id", "Name");
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,AdditionalDescription,ModelId,MaterialId,GenderId,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", product.GenderId);
            ViewData["MaterialId"] = new SelectList(_context.Materials, "Id", "Name", product.MaterialId);
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", product.ModelId);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", product.GenderId);
            ViewData["MaterialId"] = new SelectList(_context.Materials, "Id", "Name", product.MaterialId);
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", product.ModelId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,AdditionalDescription,ModelId,MaterialId,GenderId,Price")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            ViewData["GenderId"] = new SelectList(_context.Genders, "Id", "Name", product.GenderId);
            ViewData["MaterialId"] = new SelectList(_context.Materials, "Id", "Name", product.MaterialId);
            ViewData["ModelId"] = new SelectList(_context.Models, "Id", "Id", product.ModelId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .Include(p => p.Gender)
                .Include(p => p.Material)
                .Include(p => p.Model)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.SingleOrDefaultAsync(m => m.Id == id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Id == id);
        }
    }
}
