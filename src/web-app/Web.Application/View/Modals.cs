namespace Ideact.Web.Application.View
{
    public static class Modals
    {
        public static Modal DeletePromptDialog(string jsDeleteCallback)
        {
            return new ModalBuilder()
                .Title("Delete Item")
                .Text("Do you want to delete this item?")
                .Button(ButtonType.Delete)
                .JsCallback(jsDeleteCallback)
                .Button(ButtonType.Cancel)
                .Modal();
        }
    }
}