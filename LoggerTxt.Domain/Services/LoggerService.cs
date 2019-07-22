using LoggerTxt.Domain.Interfaces.Repository.Files;
using LoggerTxt.Domain.Interfaces.Services.Files;
using LoggerTxt.Domain.Models;
using LoggerTxt.Domain.Validation;
using System;
using System.Collections.Generic;
using System.IO;

namespace LoggerTxt.Domain.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILoggerRepository _loggerRepository;
        const string LOG_FILE_NAME = "{0}_{1}_v{2}.txt";
        const string LOG_FOLDER = "logs";
        private double GetVerssion() => 1.0;

        public LoggerService(ILoggerRepository loggerRepository)
        {
            _loggerRepository = loggerRepository;
        }

        public void Write(string Message, string Context = "Service")
        {
            LoggerModel logger = MakeLogger(Message, Context);
            _loggerRepository.SaveLog(logger);
        }

        public void Write(List<string> Messages, string Context = "Service")
        {
            foreach (var msg in Messages)
            {
                LoggerModel logger = MakeLogger(msg, Context);
                _loggerRepository.SaveLog(logger);
            }
        }

        private LoggerModel MakeLogger(string Message, string Context)
        {
            string currentPath = _loggerRepository.ReturPath();
            string fileDestination = String.Format(LOG_FILE_NAME, DateTime.Now.ToString("dd-MM-yyyy"), Context.RemoveEspecialCaractere(), GetVerssion());
            string path = Path.Combine(currentPath, fileDestination);
            string msg = String.Format("v. {0} # {1} - {2}", GetVerssion(), DateTime.Now.ToString("HH:mm:ss"), Message);

            return new LoggerModel(msg, path);
        }
    }
}