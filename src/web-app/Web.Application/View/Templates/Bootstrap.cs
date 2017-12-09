namespace Ideact.Web.Application.View.Templates
{
    public class Bootstrap : ITemplate
    {
        public string ClassFor(ButtonType buttonType)
        {
            string @class = "btn ";
            switch (buttonType)
            {
                case ButtonType.Accept:
                case ButtonType.Aggree:
                case ButtonType.Confirm:
                case ButtonType.Yes:
                    @class += "btn-success";
                    break;
                case ButtonType.Deny:
                case ButtonType.Disaggree:
                case ButtonType.Refuse:
                case ButtonType.No:
                case ButtonType.OK:
                case ButtonType.Cancel:
                    @class += "btn-default";
                    break;
                case ButtonType.Delete:
                    @class += "btn-danger";
                    break;
                default:
                    @class = string.Empty;
                    break;
            }

            return @class;
        }
    }
}