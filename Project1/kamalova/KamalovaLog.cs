using core;
using System.Collections.Generic;

namespace Kamalova
{
    class KamalovaLog: LogAbstract, LogInterface
    {
        private static KamalovaLog instance;

        private List<string> logs;
        public KamalovaLog()
        {
            instance = this;
            logs = new List<string>();
        }
        static public KamalovaLog I()
        {
            if (instance == null)
                instance = new KamalovaLog();
            return instance;
        }
        public LogInterface log(string str)
        {

            //добавить лог в список логов
            logs.Add(str);
            return I();
        }
        public LogInterface write()
        {
            //вывести в конслоль
            foreach (string log in logs)
                base.writeConsole(log);
            return I();
        }
    }
}