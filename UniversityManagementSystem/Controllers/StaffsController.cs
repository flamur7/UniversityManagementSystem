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
    public class StaffsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public StaffsController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Staffs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Staffs.Include(s => s.Branch).Include(s => s.Nationality);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Staffs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs
                .Include(s => s.Branch)
                .Include(s => s.Nationality)
                .FirstOrDefaultAsync(m => m.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName");
                return View(new Staff());
            }
            else
            {
                var staff = await _context.Staffs.FindAsync(id);
                if (staff == null)
                {
                    return NotFound();
                }


                ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName");
                return View(staff);
            }
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("StaffId,StaffName,StaffRole,Image,Email,StartJob,BranchId,NationalityId")] Staff staff, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    var searchStudent = _context.Staffs.FirstOrDefault(p => p.StaffId == staff.StaffId);
                    if (searchStudent != null)
                    {
                        ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName");
                        ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName");
                        return View(staff);
                    }

                    if (image != null)
                    {
                        var name = Path.Combine(_hostingEnvironment.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                        await image.CopyToAsync(new FileStream(name, FileMode.Create));
                        staff.Image = "Images/" + image.FileName;
                    }

                    if (image == null)
                    {
                        staff.Image = "Image/noimage.png";
                    }
                    _context.Add(staff);
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
                            staff.Image = "Images/" + image.FileName;
                        }

                        if (image == null)
                        {
                            staff.Image = "Images/noimage.png";
                        }
                        _context.Update(staff);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!StaffExists(staff.StaffId))
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
                ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName");
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_StaffsTablePartialView", _context.Staffs.ToList()) });

            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", staff) });
        }

        // GET: Staffs/Edit/5
        public async Task<IActionResult> Edit(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", staff.BranchId);
            ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName", staff.NationalityId);
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffId,StaffName,StaffRole,Image,Email,StartJob,BranchId,NationalityId")] Staff staff, IFormFile image)
        {
            if (id != staff.StaffId)
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
                        staff.Image = "Images/" + image.FileName;
                    }

                    if (image == null)
                    {
                        staff.Image = "Images/noimage.png";
                    }
                    _context.Update(staff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffExists(staff.StaffId))
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

            ViewData["BranchId"] = new SelectList(_context.Branches, "BranchId", "BranchName", staff.BranchId);
            ViewData["NationalityId"] = new SelectList(_context.Nationalitys, "NationalityId", "NationalityName", staff.NationalityId);
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staffs
                .Include(s => s.Branch)
                .Include(s => s.Nationality)
                .FirstOrDefaultAsync(m => m.StaffId == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);
            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffExists(int id)
        {
            return _context.Staffs.Any(e => e.StaffId == id);
        }
    }
}
