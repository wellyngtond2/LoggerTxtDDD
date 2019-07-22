using System.Collections.Generic;

namespace LoggerTxt.Domain.Interfaces.Services.Files
{
    public interface ILoggerService : IFileServiceBase
    {
        void Write(string Message, string Context = "Service");
        void Write(List<string> Messages, string Context = "Service");
    }
}
