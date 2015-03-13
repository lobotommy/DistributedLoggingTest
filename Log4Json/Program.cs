using System;
using System.Diagnostics;
using System.Threading;
using log4net;

namespace Log4Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetLogger("Logger");
            for (var cnt = 0; cnt < 100; cnt++)
            {
                var sw = Stopwatch.StartNew();
                logger.Debug("Test " + cnt);
                sw.Stop();
                Console.WriteLine(sw.ElapsedMilliseconds);
                Thread.Sleep(1000);
            }
        }
    }
}
