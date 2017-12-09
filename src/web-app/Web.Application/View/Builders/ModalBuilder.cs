using System.Collections.Generic;

using Ideact.Web.Application.Utilities;

namespace Ideact.Web.Application.View
{
    public class ModalBuilder
    {
        private string title;
        private string text;
        private List<ModalButton> buttons;

        public ModalBuilder()
        {
            buttons = new List<ModalButton>();
        }

        public ModalBuilder Title(string title)
        {
            this.title = title;

            return this;
        }

        public ModalBuilder Text(string text)
        {
            this.text = text;

            return this;
        }

        public ModalButtonBuilder Button(ButtonType buttonType)
        {
            var button = new ModalButton
            {
                Class = Css.ClassFor(buttonType),
                ClosesModal = true,
                Text = Utilities.Text.For(buttonType)
            };
            buttons.Add(button);

            return new ModalButtonBuilder(this, button);
        }

        public virtual Modal Modal()
        {
            var modal = new Modal
            {
                Text = text,
                Title = title
            };

            buttons.ForEach(x => x.ModalId = modal.Id);

            modal.Buttons = buttons.ToArray();

            return modal;
        }
    }
}