using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UniversityManagementSystem.Data;
using UniversityManagementSystem.Models;

namespace UniversityManagementSystem.Views
{
    public class AssessmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AssessmentsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Assessments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Assessments.Include(a => a.Exam).Include(a => a.Grade);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Sidebar()
        {
            var applicationDbContext = _context.Assessments.Include(a => a.Exam).Include(a => a.Grade);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Assessments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessments
                .Include(a => a.Exam)
                .Include(a => a.Grade)
                .FirstOrDefaultAsync(m => m.AssessmentId == id);
            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["ExamId"] = new SelectList(_context.Exams, "ExamId", "Subject");
                ViewData["GradeId"] = new SelectList(_context.Grades, "GradeId", "GradeName");
                return View(new Assessment());
            }
            else
            {
                var assessment = await _context.Assessments.FindAsync(id);
                if (assessment == null)
                {
                    return NotFound();
                }

                ViewData["ExamId"] = new SelectList(_context.Exams, "ExamId", "Subject");
                ViewData["GradeId"] = new SelectList(_context.Grades, "GradeId", "GradeName");
                return View(assessment);
            }
        }



        // POST: Assessments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("AssessmentId,StudentCode,FullName,Image,ExamId,GradeId")] Assessment assessment, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var searchAssesments = _context.Assessments.FirstOrDefault(p => p.AssessmentId == assessment.AssessmentId);
                    if (searchAssesments != null)
                    {
                        ViewData["ExamId"] = new SelectList(_context.Exams, "ExamId", "Subject");
                        ViewData["GradeId"] = new SelectList(_context.Grades, "GradeId", "GradeName");
                        return View(assessment);
                    }

                    if (image != null)
                    {
                        var name = Path.Combine(_hostingEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(name, FileMode.Create));
                        assessment.Image = "Images/" + image.FileName;
                    }

                    if (image == null)
                    {
                        assessment.Image = "Image/noimage.png";
                    }
                    _context.Add(assessment);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        if (image != null)
                        {
                            var name = Path.Combine(_hostingEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                            await image.CopyToAsync(new FileStream(name, FileMode.Create));
                            assessment.Image = "Images/" + image.FileName;
                        }

                        if (image == null)
                        {
                            assessment.Image = "Images/noimage.png";
                        }
                        _context.Update(assessment);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!AssessmentExists(assessment.AssessmentId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                ViewData["ExamId"] = new SelectList(_context.Exams, "ExamId", "Subject");
                ViewData["GradeId"] = new SelectList(_context.Grades, "GradeId", "GradeName");
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_AssessmentsTablePartialView", _context.Assessments.ToList()) });

            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", assessment) });

        }




        // GET: Assessments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessments.FindAsync(id);
            if (assessment == null)
            {
                return NotFound();
            }
            ViewData["ExamId"] = new SelectList(_context.Exams, "ExamId", "Subject", assessment.ExamId);
            ViewData["GradeId"] = new SelectList(_context.Grades, "GradeId", "GradeName", assessment.GradeId);
            return View(assessment);
        }

        // POST: Assessments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssessmentId,StudentCode,FullName,Image,ExamId,GradeId")] Assessment assessment)
        {
            if (id != assessment.AssessmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assessment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssessmentExists(assessment.AssessmentId))
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
            ViewData["ExamId"] = new SelectList(_context.Exams, "ExamId", "Subject", assessment.ExamId);
            ViewData["GradeId"] = new SelectList(_context.Grades, "GradeId", "GradeName", assessment.GradeId);
            return View(assessment);
        }

        // GET: Assessments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessments
                .Include(a => a.Exam)
                .Include(a => a.Grade)
                .FirstOrDefaultAsync(m => m.AssessmentId == id);
            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        // POST: Assessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assessment = await _context.Assessments.FindAsync(id);
            _context.Assessments.Remove(assessment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssessmentExists(int id)
        {
            return _context.Assessments.Any(e => e.AssessmentId == id);
        }
    }
}
