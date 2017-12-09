using NCommons.Asp.Net;

namespace Ideact.Web.Application.View
{
    [PartialView("PropertyView")]
    public class Property : Vdto
    {
        public string Text { get; set; }

        public Property()
        {
        }

        public Property(string text)
        {
            Text = text;
        }
    }
}