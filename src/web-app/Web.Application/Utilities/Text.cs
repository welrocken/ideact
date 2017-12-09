using Ideact.Web.Application.View;

namespace Ideact.Web.Application.Utilities
{
    public class Text
    {
        public static string For(ButtonType buttonType)
        {
            return buttonType.ToString();
        }
    }
}