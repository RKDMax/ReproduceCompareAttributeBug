using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ReproduceCompareAttributeBug.Pages
{

    public class ViewModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name = "Confirm Name"), Compare("Name", ErrorMessage = "Names must match!")]
        public string ConfirmName { get; set; }
    }

    public class ThisWorksModel : PageModel
    {

        [BindProperty]
        public ViewModel ViewModel { get; set; }

        public void OnGet()
        {

        }
    }
}