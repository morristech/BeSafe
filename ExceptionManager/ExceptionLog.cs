using System;

namespace ExceptionManager
{
    [Serializable]
    public class ExceptionLog
    {
        public ExceptionType Type { get; set; }
        public DateTime Date { get; set; }
        public string FilePath { get; set; }
        public string MethodName { get; set; }
        public int LineNumber { get; set; }
        public string Description { get; set; }
        public Exception Exception { get; set; }
    }
}