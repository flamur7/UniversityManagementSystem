using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using UniversityManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

public class IndexModel : PageModel
{
    public void OnGet()
    {
        // this handler returns Index page
    }

    public PartialViewResult OnGetContactModalPartial()
    {
        // this handler returns _ContactModalPartial
        return new PartialViewResult
        {
            ViewName = "_ContactModalPartial",
            ViewData = new ViewDataDictionary<Student>(ViewData, new Student { })
        };
    }
}