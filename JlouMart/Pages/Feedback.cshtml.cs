using JlouMart.Data;
using JlouMart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace JlouMart.Pages
{
    public class FeedbackModel : PageModel
    {
        private readonly FeedbackContext _context;
        public string errorMessage = string.Empty;

        public FeedbackModel(FeedbackContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Respondent Respondent { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            errorMessage = string.Empty;
            Respondent temp = await _context.Respondents.FindAsync(Respondent.Email);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (temp == null)
            {
                _context.Respondents.Add(Respondent);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            else 
            {
                //Do something better when email is used again.
                errorMessage = "Uh-oh! It seems like this email has been used.";
                return Page();
            }



        }
    }
}
