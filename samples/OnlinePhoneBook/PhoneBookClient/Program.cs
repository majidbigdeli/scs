﻿using System;
using Hik.Communication.Mbt.Communication.EndPoints.Tcp;
using Hik.Communication.MbtServices.Client;
using PhoneBookCommonLib;

/* This is a simple client application that uses phone book server.
 */

namespace PhoneBookClient
{
    class Program
    {
        static void Main()
        {
            //Create a client to connecto to phone book service on local server and 10048 TCP port.
            var client = MbtServiceClientBuilder.CreateClient<IPhoneBookService>(
                new MbtTcpEndPoint("127.0.0.1", 10048));

            Console.WriteLine("Press enter to connect to phone book service...");
            Console.ReadLine();

            //Connect to the server
            client.Connect();

            var person1 = new PhoneBookRecord { Name = "Majid Bigdeli", Phone = "5881112233" };
            var person2 = new PhoneBookRecord { Name = "Zeinab Ghasabi", Phone = "58833322211" };

            //Add some persons
            client.ServiceProxy.AddPerson(person1);
            client.ServiceProxy.AddPerson(person2);

            //Search for a person
            var person = client.ServiceProxy.FindPerson("Majid");
            if (person != null)
            {
                Console.WriteLine("Person is found:");
                Console.WriteLine(person);
            }
            else
            {
                Console.WriteLine("Can not find person!");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to disconnect from phone book service...");
            Console.ReadLine();

            //Disconnect from server
            client.Disconnect();
        }
    }
}
