using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_13
{
    class ParserEx : Parser4
    {
      
        public override int Parse(string s)
        {
            var ds = DateTime.Now;
            var r = base.Parse(s);
            Console.Write("Computing Time: {0}\n",(DateTime.Now - ds).TotalMilliseconds);

            
            return r;
        }

    }

}
