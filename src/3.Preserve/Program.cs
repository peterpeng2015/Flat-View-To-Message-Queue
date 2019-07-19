using DBHelper;
using log4net.Config;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Preserve
{
    class Program
    {
        /// <summary>
        ///  程序入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string assemblyFilePath = Assembly.GetExecutingAssembly().Location;
            string configFilePath = Path.GetDirectoryName(assemblyFilePath);

            XmlConfigurator.ConfigureAndWatch(new FileInfo(configFilePath + "\\log4net.config"));

            Engine.Start();

            Console.ReadLine();
        }
    }
}
