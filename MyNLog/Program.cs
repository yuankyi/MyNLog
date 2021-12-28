using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyNLog
{
    class Program
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly NLog.Logger mylogger = NLog.LogManager.GetLogger("mylogger");

        static void Main(string[] args)
        {
            do
            {
                logger.Info("Hello world");
                //Structured logging is recommended, e.g.
                logger.Info("Hello {Name}", "Earth");
                //Or using string-format syntax:
                logger.Info("Hello {0}", "Moon");

                try
                {
                    int i = 0, j = 1;
                    var xx = j / i;
                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Goodbye cruel world");
                    mylogger.Error(ex, "my error ..");
                }

                Console.ReadKey();
            }
            while (true);
        }
    }
}
