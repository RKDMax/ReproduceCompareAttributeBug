using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace ReproduceCompareAttributeBug.Pages
{

    public class ThisDoesNotWorkModel : PageModel
    {

        [BindProperty, Required]
        public string Name { get; set; }

        [BindProperty, Display(Name = "Confirm Name"), Compare("Name", ErrorMessage = "Names must match!")]
        public string ConfirmName { get; set; }

        public void OnGet()
        {

        }
    }
}