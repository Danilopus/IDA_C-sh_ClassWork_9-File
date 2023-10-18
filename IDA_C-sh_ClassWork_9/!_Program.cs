// ClassWork template 1.2 // date: 29.09.2023

using IDA_C_sh_ClassWork_9;
using Service;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;



// ClassWork 09 : [Csharp Filesystem] 18.10.2023 --------------------------------

namespace IDA_C_sh_ClassWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            Console.WriteLine(arg);

            Directory.GetCurrentDirectory();

            //Task_1();
             Task_2();
            // Task_3();

            Console.ReadKey();

        }

        public static void Task_1() 
        {
            string path = Path.GetTempFileName();     
            //Path.Get

            // Through System.IO.File 
            //FileStream str_1 = File.Create(path);
            FileStream str_1 = new(path, FileMode.Open);


            StreamWriter streamWriter_1 = new StreamWriter(str_1);
            streamWriter_1.WriteLine("streamWriter_1 string_1");
            streamWriter_1.WriteLine("streamWriter_1 string_2");
            streamWriter_1.WriteLine("streamWriter_1 string_3");
            streamWriter_1.Close();

            //_ = str_1.CanRead;
            str_1 = new(path, FileMode.OpenOrCreate);
            //FileStream str_for_read = new(path, FileMode.Open);
            StreamReader streamReader_3 = new StreamReader(str_1);
            //StreamReader streamReader_3 = new StreamReader(str_for_read);
            string read_result = streamReader_3.ReadToEnd();
            Console.WriteLine(read_result);


            // Through System.IO.FileOnfo
            string path_2 = Path.GetTempFileName();
            FileInfo new_fileinfo_obj = new FileInfo(path_2);            
            FileStream str_2 = new_fileinfo_obj.Create();
            string path_3 = Path.GetTempFileName();
            FileStream str_3 = new FileInfo(path_3).Create();         


        }
        public static void Task_2() 
        {
        try { throw new Exception("test exeption"); }
        //catch (Exception ex) { new ExceptionHandler(ex, TypeInfo_ = true, FullTypeInfo_ = false, StackTrace_ = false); }
        catch (Exception ex) 
            { 
                new ExceptionHandler(ex, false, false, false, false);
                new ExceptionHandler(ex, false, false, true, false) ;
            }
        }
        public static void Task_3() { }

    } // class Programm
}// namespace

