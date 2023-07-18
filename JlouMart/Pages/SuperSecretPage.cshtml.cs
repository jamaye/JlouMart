using JlouMart.Data;
using JlouMart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JlouMart.Pages
{ 
	public class SuperSecretPageModel : PageModel
    {
		private readonly FeedbackContext _context;

        public SuperSecretPageModel(FeedbackContext context)
        {
            _context = context;
        }

        public List<Respondent> Respondents { get; set; }
		public async Task OnGetAsync()
		{
			Respondents = await _context.Respondents.ToListAsync();
		}

		public async Task<IActionResult> OnPostAsync(string email)
		{
			if(email == null) 
			{
				return NotFound();
			}
			Respondent Respondent = await _context.Respondents.FindAsync(email);
			if(Respondent != null)
			{
				_context.Respondents.Remove(Respondent);
			}

			await _context.SaveChangesAsync();
			return RedirectToPage("/Success", new { back = "1" });
		}
	}
}
