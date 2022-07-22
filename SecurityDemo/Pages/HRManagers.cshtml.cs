using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecurityDemo.Pages
{
    [Authorize(Policy = "HRManager")]
    public class HRManagersModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
