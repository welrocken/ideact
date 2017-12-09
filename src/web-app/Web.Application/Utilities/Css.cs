using Ideact.Web.Application.View;

namespace Ideact.Web.Application.Utilities
{
    public static class Css
    {
        public static ITemplate CurrentTemplate { get; internal set; }

        public static string ClassFor(ButtonType buttonType)
        {
            return CurrentTemplate.ClassFor(buttonType);
        }
    }
}