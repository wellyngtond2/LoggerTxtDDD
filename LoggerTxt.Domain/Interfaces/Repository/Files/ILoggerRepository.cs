using LoggerTxt.Domain.Models;

namespace LoggerTxt.Domain.Interfaces.Repository.Files
{
    public interface ILoggerRepository: IFileRepositoryBase
    {
        void SaveLog(LoggerModel log);
    }
}
