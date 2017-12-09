using System.Collections.Generic;

using NCommons.Asp.Net;

namespace Ideact.Web.Application.View
{
    [PartialView("PropertiesView")]
    public class Properties : Vdto
    {
        public string ModalId { get; set; }
        public string Title { get; set; }
        public IList<Property> Items { get; set; }
    }
}