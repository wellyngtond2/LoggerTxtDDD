using LoggerTxt.Domain.Interfaces.Repository.Files;
using LoggerTxt.Domain.Models;
using System;
using System.IO;

namespace LoggerTxt.Domain.Interfaces.Files
{
    public class LoggerRepository : ILoggerRepository
    {
        /*<summary>
         * Return the local path
         * </summary>*/
        public string ReturPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public void SaveLog(LoggerModel log)
        {
            using (StreamWriter sw = File.AppendText(log.Path))
            {
                sw.WriteLine(log.Message);
                sw.Flush();
            }
        }
    }
}
