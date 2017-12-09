using NCommons.Asp.Net;

namespace Ideact.Web.Application.View
{
    [PartialView("ModalView")]
    public class Modal : Vdto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public ModalButton[] Buttons { get; set; }
    }
}