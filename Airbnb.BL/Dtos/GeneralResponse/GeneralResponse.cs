
namespace Airbnb.BL.Dtos.GeneralResponse
{
    public class GeneralResponse
    {
        public string Message { set; get; } = string.Empty;

        public GeneralResponse (string message)
        {
            Message = message;
        }
    }
}
