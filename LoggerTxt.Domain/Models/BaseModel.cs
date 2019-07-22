using System;

namespace LoggerTxt.Domain.Models
{
    public abstract class BaseModel
    {
        public DateTime CurrentDate { get; private set; }
        public BaseModel()
        {
            CurrentDate = DateTime.Now;
        }
    }
}