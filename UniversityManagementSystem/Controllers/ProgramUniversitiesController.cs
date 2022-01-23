using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Views
{
    public class ProgramUniversitiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProgramUniversitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProgramUniversities
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProgramUniversity.ToListAsync());
        }

        // GET: ProgramUniversities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programUniversity = await _context.ProgramUniversity
                .FirstOrDefaultAsync(m => m.ProgramUniversityId == id);
            if (programUniversity == null)
            {
                return NotFound();
            }

            return View(programUniversity);
        }

        // GET: ProgramUniversities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProgramUniversities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProgramUniversityId,ProgramUniversityName")] ProgramUniversity programUniversity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(programUniversity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(programUniversity);
        }

        // GET: ProgramUniversities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programUniversity = await _context.ProgramUniversity.FindAsync(id);
            if (programUniversity == null)
            {
                return NotFound();
            }
            return View(programUniversity);
        }

        // POST: ProgramUniversities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProgramUniversityId,ProgramUniversityName")] ProgramUniversity programUniversity)
        {
            if (id != programUniversity.ProgramUniversityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(programUniversity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProgramUniversityExists(programUniversity.ProgramUniversityId))
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
            return View(programUniversity);
        }

        // GET: ProgramUniversities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programUniversity = await _context.ProgramUniversity
                .FirstOrDefaultAsync(m => m.ProgramUniversityId == id);
            if (programUniversity == null)
            {
                return NotFound();
            }

            return View(programUniversity);
        }

        // POST: ProgramUniversities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programUniversity = await _context.ProgramUniversity.FindAsync(id);
            _context.ProgramUniversity.Remove(programUniversity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProgramUniversityExists(int id)
        {
            return _context.ProgramUniversity.Any(e => e.ProgramUniversityId == id);
        }
    }
}
