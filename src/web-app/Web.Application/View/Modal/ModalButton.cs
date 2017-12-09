using NCommons.Asp.Net;

namespace Ideact.Web.Application.View
{
    [PartialView("ModalButtonView")]
    public class ModalButton : Vdto
    {
        public string ModalId { get; set; }
        public string Text { get; set; }
        public string Class { get; set; }
        public bool ClosesModal { get; set; }
        public string JsCallback { get; set; }
    }
}