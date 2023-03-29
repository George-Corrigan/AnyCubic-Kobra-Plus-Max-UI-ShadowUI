using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web.ShadowUI.Pages
{
    public class Translate_Model : PageModel
    {

        public Translate_Model(Microsoft.Extensions.Localization.IStringLocalizer<Pages.Index_Model> stringLocalizer) : base(stringLocalizer) { }

        public void OnGet()
        {
        }

    }
}
