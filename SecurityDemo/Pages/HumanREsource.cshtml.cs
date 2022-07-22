using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SecurityDemo.Pages
{
    [Authorize(Policy = "MustBelongToDepartment")]
    public class HumanREsourceModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
