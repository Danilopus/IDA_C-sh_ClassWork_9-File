using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDA_C_sh_ClassWork_9
{
    internal class ExceptionHandler
    {
        public bool TypeInfo_ { get; set; } = true;
        public bool FullTypeInfo_ { get; set; } = true;
        public bool StackTrace_ { get; set; } = true;
        public bool Message_ { get; set; } = true; 

        public ExceptionHandler(Exception ex, bool Message = true, bool TypeInfo = true, bool FullTypeInfo = true, bool StackTrace = true)
        {
            this.Message_ = Message;
            this.TypeInfo_ = TypeInfo;
            this.FullTypeInfo_ = FullTypeInfo;
            this.StackTrace_ = StackTrace;

            string log_message = $"\nTimeStamp: {DateTime.Now}";
                if (Message_) log_message += $"\nMessage: {ex.Message}";
                if (FullTypeInfo_) log_message += $"\nInfo: {ex.ToString()}";
                if (TypeInfo_) log_message += $"\nType: {ex.GetType()}";
                if (StackTrace_) log_message += "\n"+ ex.StackTrace;
            
            new FileLogger(log_message);
            Console.WriteLine(log_message);
        }
        class FileLogger
        {
        public string Path_ { get; set; }  = Directory.GetCurrentDirectory()+ "\\log_file.log";
        public FileLogger(string log_message) 
            { 
                if (!File.Exists(Path_)) { File.Create(Path_).Close(); }
                StreamWriter streamWriter = new StreamWriter(Path_, true, Encoding.UTF8);
                //StreamWriter streamWriter = new StreamWriter(Path_);
                streamWriter.WriteLine(log_message);
                streamWriter.Close();
            }
        }
    }
}
