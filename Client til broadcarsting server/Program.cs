﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Threading;

namespace ChatClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Run();
        }
        public void Run()
        {
            string servername = Console.ReadLine();
            int port = int.Parse(Console.ReadLine());
            ServerFacade severFacade = new ServerFacade(port, servername);
        }
    }
}
