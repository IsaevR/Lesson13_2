using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("\n\n\t\tПоддерживаемые операции: +, -, *, /, !(факториал)");
            Console.WriteLine("\t\tВведите числовые выражения.\n\n\n");

            
            var str = Console.ReadLine();
            ParserEx parser = new ParserEx();
            Console.Clear();
            Console.Write("{0} = {1}\n", str, parser.Parse(str));

            var jsonfile = new List<int>();
            jsonfile.Add(parser.Parse(str));
            
            
            string s = JsonConvert.SerializeObject(jsonfile);
            File.AppendAllText(@"c:/tmp/text2.txt", s);
           
            
            Console.ReadLine();
         
        }
    }
}
