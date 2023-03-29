using System;

namespace Web.ShadowUI.Pages
{
    public class PageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {

        private Microsoft.AspNetCore.Localization.RequestCulture RequestCulture;
        private readonly Microsoft.Extensions.Localization.IStringLocalizer<Pages.Index_Model> StringLocalizer;

        public PageModel(Microsoft.Extensions.Localization.IStringLocalizer<Pages.Index_Model> stringLocalizer)
        {
            //RequestCulture = Request.HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>().RequestCulture;
            StringLocalizer = stringLocalizer;
        }

        public string GetCultureName()
        {
            //Microsoft.AspNetCore.Localization.RequestCultureFeature requestCultureFeature = (Microsoft.AspNetCore.Localization.RequestCultureFeature)Request.HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>();
            if (RequestCulture == null)
            {
                RequestCulture = Request.HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>().RequestCulture;
            }

            //? requestCultureFeature.RequestCulture.Culture.Name
            //"zh-Hans"
            //? requestCultureFeature.RequestCulture.Culture.DisplayName
            //"Chinese (Simplified)"
            //? requestCultureFeature.RequestCulture.Culture.EnglishName
            //"Chinese (Simplified)"
            //? requestCultureFeature.RequestCulture.Culture.NativeName
            //"中文(简体)"

            return RequestCulture.Culture.Name; // .EnglishName;
        }

        public int GetFontSizeOffset()
        {
            if (RequestCulture == null)
            {
                RequestCulture = Request.HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>().RequestCulture;
            }
            return Array.Find<Tuple<string, string, int>>(Cultures.List(), delegate (Tuple<string, string, int> value)
            {
                return value.Item2.Equals(RequestCulture.Culture.Name, StringComparison.CurrentCultureIgnoreCase);
            }).Item3;
        }

        public string GetCultureText(string name)
        {
            if (RequestCulture == null)
            {
                RequestCulture = Request.HttpContext.Features.Get<Microsoft.AspNetCore.Localization.IRequestCultureFeature>().RequestCulture;
            }
            return Cultures.CheckCultureText(RequestCulture.Culture.Name, StringLocalizer[name]);
        }

    }
}
