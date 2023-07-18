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
            if(back == "1")
                Back = "SuperSecretPage";
            else if(back == "2")
                Back = "Feedback";
        }
		public void OnPost()
		{
           
		}
    }
}
