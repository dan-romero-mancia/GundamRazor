using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GundamRazor.Data;
using GundamRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace GundamRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly GundamContext context; 
        public ModelKit[] PopularModelKits;

        public IndexModel(GundamContext context) {
            this.context = context;
        }
        public void OnGet()
        {
            // Only done for testing, change later
            PopularModelKits = context.ModelKits.Where(m => m.Grade == ModelKit.GradeEnum.MG)
                .Include(m => m.MobileSuit)
                .ToArray();
        }
    }
}
