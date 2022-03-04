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
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public StudentsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Students.Include(s => s.Branch).Include(s => s.Nationality).Include(s => s.ProgramUniversity);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Branch)
                .Include(s => s.Nationality)
                .Include(s => s.ProgramUniversity)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
            ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName");
            ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityId", "ProgramUniversityName");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,PersonalNumber,StudentName,ParentName,Surname,Image,Birthday,Birthplace,ProgramUniversityId,NationalityId,BranchId")] Student student, IFormFile image)
        {
            var searchStudent = _context.Students.FirstOrDefault(p => p.StudentId == student.StudentId);
            if (searchStudent != null)
            {
                ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.BranchId);
                ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName", student.NationalityId);
                ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityId", "ProgramUniversityName", student.ProgramUniversityId);
                return View(student);
            }

            if (image != null)
            {
                var name = Path.Combine(_hostingEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                await image.CopyToAsync(new FileStream(name, FileMode.Create));
                student.Image = "Images/" + image.FileName;
            }

            if (image == null)
            {
                student.Image = "Image/noimage.png";
            }
            _context.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            _context.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


     
        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.BranchId);
            ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName", student.NationalityId);
            ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityId", "ProgramUniversityName", student.ProgramUniversityId);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,PersonalNumber,StudentName,ParentName,Surname,Image,Birthday,Birthplace,ProgramUniversityId,NationalityId,BranchId")] Student student, IFormFile image)
        {
            if (id != student.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (image != null)
                    {
                        var name = Path.Combine(_hostingEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(name, FileMode.Create));
                        student.Image = "Images/" + image.FileName;
                    }

                    if (image == null)
                    {
                        student.Image = "Images/noimage.png";
                    }
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.StudentId))
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
            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", student.BranchId);
            ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName", student.NationalityId);
            ViewData["ProgramUniversityId"] = new SelectList(_context.ProgramUniversity, "ProgramUniversityId", "ProgramUniversityName", student.ProgramUniversityId);
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .Include(s => s.Branch)
                .Include(s => s.Nationality)
                .Include(s => s.ProgramUniversity)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.StudentId == id);
        }
    }
}
