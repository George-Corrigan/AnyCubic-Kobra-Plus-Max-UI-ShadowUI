using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.ShadowUI.Pages
{
    public class Index_Model : PageModel
    {

        public Index_Model(Microsoft.Extensions.Localization.IStringLocalizer<Pages.Index_Model> stringLocalizer) : base(stringLocalizer) { }

        public string CssClass = "";

        public string CurrentPage = "";

        public void OnGet()
        {
        }

    }
}
