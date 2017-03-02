using System.Web.Mvc;

namespace Naiva.Areas.WorkExperience
{
    public class WorkExperienceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WorkExperience";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WorkExperience_default",
                "WorkExperience/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}