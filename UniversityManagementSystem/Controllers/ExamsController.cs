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
    public class ExamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Exams
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Exams.Include(e => e.Branch).Include(e => e.Professor).Include(e => e.ProgramUniversity);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Exams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.Branch)
                .Include(e => e.Professor)
                .Include(e => e.ProgramUniversity)
                .FirstOrDefaultAsync(m => m.ExamId == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                ViewData["ProfessorId"] = new SelectList(_context.Professors, "ProfessorId", "ProfessorName");
                ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityName", "ProgramUniversityName");
                return View(new Exam());
            }
            else
            {
                var exam = await _context.Exams.FindAsync(id);
                if (exam == null)
                {
                    return NotFound();
                }

                ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                ViewData["ProfessorId"] = new SelectList(_context.Professors, "ProfessorId", "ProfessorName");
                ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityName", "ProgramUniversityName");
                return View(exam);
            }
        }
        mos naj najana e kolonave e ka ata not null ncuk osht problemi qe so mir qekejo rreshti 79

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ExamId,Subject,BranchId,ProgramUniversityId,ProfessorId")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var searchExam = _context.Exams.FirstOrDefault(p => p.ExamId == exam.ExamId);
                    if (searchExam != null)
                    {
                        ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                        ViewData["ProfessorId"] = new SelectList(_context.Professors, "ProfessorId", "ProfessorName");
                        ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityName", "ProgramUniversityName");
                        return View(exam);
                    }

                    _context.Add(exam);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(exam);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ExamExists(exam.ExamId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                
                }
                ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                ViewData["ProfessorId"] = new SelectList(_context.Professors, "ProfessorId", "ProfessorName");
                ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityName", "ProgramUniversityName");
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ExamsTablePartialView", _context.Exams.ToList()) });

            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", exam) });

        }

        // GET: Exams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", exam.BranchId);
            ViewData["ProfessorId"] = new SelectList(_context.Professors, "ProfessorId", "ProfessorName", exam.ProfessorId);
            ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityId", "ProgramUniversityName", exam.ProgramUniversityId);
            return View(exam);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExamId,Subject,BranchId,ProgramUniversityId,ProfessorId")] Exam exam)
        {
            if (id != exam.ExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamExists(exam.ExamId))
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
            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", exam.BranchId);
            ViewData["ProfessorId"] = new SelectList(_context.Professors, "ProfessorId", "ProfessorName", exam.ProfessorId);
            ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityId", "ProgramUniversityName", exam.ProgramUniversityId);
            return View(exam);
        }

        // GET: Exams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.Branch)
                .Include(e => e.Professor)
                .Include(e => e.ProgramUniversity)
                .FirstOrDefaultAsync(m => m.ExamId == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exam = await _context.Exams.FindAsync(id);
            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamExists(int id)
        {
            return _context.Exams.Any(e => e.ExamId == id);
        }
    }
}
