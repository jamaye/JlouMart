using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace JlouMart.Pages
{
    public class SuccessModel : PageModel
    {
        public string Back { get; set; }
        public void OnGet(string back)
        {
            Back = back;
        }
		public void OnPost()
		{
           
		}
    }
}
