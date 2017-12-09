using Ideact.Web.Application.Utilities;
using Ideact.Web.Application.View.Templates;

namespace Ideact.Web.Application
{
    public class TemplateConfig
    {
        public static void RegisterTemplate()
        {
            Css.CurrentTemplate = new Bootstrap();
        }
    }
}