﻿using System;
using CommonLib;
using Hik.Communication.Mbt.Client;
using Hik.Communication.Mbt.Communication.EndPoints.Tcp;
using Hik.Communication.Mbt.Communication.Messages;

namespace ClientApp
{
    class OneWayClientDefaultProtocol
    {
        public static void Run()
        {
            Console.WriteLine("Press enter to connect to server and send " + Consts.MessageCount + " messages.");
            Console.ReadLine();

            using (var client = MbtClientFactory.CreateClient(new MbtTcpEndPoint("127.0.0.1", 10033)))
            {
                client.Connect();

                for (var i = 0; i < Consts.MessageCount; i++)
                {
                    client.SendMessage(new MbtTextMessage("Hello from client!"));
                }

                Console.WriteLine("Press enter to disconnect from server");
                Console.ReadLine();
            }
        }
    }
}
