using System;

namespace Ideact.Web.Application.View
{
    public class ModalButtonBuilder : ModalBuilder
    {
        private readonly ModalBuilder _modalBuilder;
        private readonly ModalButton _button;

        public ModalButtonBuilder(ModalBuilder modalBuilder,
                                  ModalButton button)
        {
            _modalBuilder = modalBuilder ?? throw new ArgumentNullException(nameof(modalBuilder));
            _button = button ?? throw new ArgumentNullException(nameof(button));
        }

        public ModalBuilder JsCallback(string jsCallback)
        {
            _button.JsCallback = jsCallback;

            return _modalBuilder;
        }

        public override Modal Modal()
        {
            return _modalBuilder.Modal();
        }
    }
}