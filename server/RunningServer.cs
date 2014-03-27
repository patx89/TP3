using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class RunningServer
    {
        public static void Main()
        {
            ServerTCP serverTCP = new ServerTCP();

            serverTCP.OpenServer();

            serverTCP.ShutdownServer();
        }
    }
}
