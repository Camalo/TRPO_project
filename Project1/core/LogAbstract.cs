using System;

namespace core
{


    abstract public class LogAbstract
    {
        protected String formatLog(String[] strings)
        {
            return String.Join(";\n\r", strings);
        }
        protected void writeConsole(String s)
        {
            Console.WriteLine(s);
        }
        protected void writeConsole(String[] s)
        {
            Console.WriteLine(formatLog(s));
        }
    }

}