namespace LoggerTxt.Domain.Models
{
    public class LoggerModel : BaseModel
    {
        public LoggerModel(string message, string path)
        {
            Message = message;
            Path = path;
        }

        public string Message { get; private set; }
        public string Path { get; private set; }
    }
}
