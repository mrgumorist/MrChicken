﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using IService;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(IService.ProgrammService)))
            {
                host.Open();
                Console.WriteLine($"@Host started {DateTime.Now.ToString()}...");
                Console.ReadLine();
            }
        }
    }
}
