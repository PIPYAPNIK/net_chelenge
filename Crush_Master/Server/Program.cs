using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    class Program
    {
        class Client
        {
            public Socket Socket { get; set; }
            public int ID { get; set; }

            public Client(Socket socket)
            {
                Socket = socket;
            }
        }
        static Socket socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        static List<Client> clients = new List<Client>();
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.Title = "Server";

            socket.Bind(new IPEndPoint(IPAddress.Any, 2048));
            socket.Listen(0);

            socket.BeginAccept(AcceptCallback, null);

            Console.ReadLine();
        }

        static void AcceptCallback(IAsyncResult ar)
        {
            Client client = new Client(socket.EndAccept(ar));
            Thread thread = new Thread(HandleClient);
            thread.Start(client);
            clients.Add(client);
            Console.WriteLine("Новое подключение");

            socket.BeginAccept(AcceptCallback, null);
        }

        static void HandleClient(object o)
        {
            Client client = (Client)o;
            MemoryStream ms = new MemoryStream(new byte[256], 0, 256, true, true);
            BinaryWriter writer = new BinaryWriter(ms);
            BinaryReader reader = new BinaryReader(ms);

            while (true)
            {
                ms.Position = 0;
                client.Socket.Receive(ms.GetBuffer());
                int code = reader.ReadInt32();

                switch (code)
                {
                    case 0:
                        while (true)
                        {
                            int id = random.Next(0, 1001);
                            if (clients.Find(c => c.ID == id) == null)
                            {
                                writer.Write(id);
                                client.Socket.Send(ms.GetBuffer());
                                client.ID = id;
                                break;
                            }

                        }
                        break;


                    case 1:
                        foreach (var c in clients)
                        {
                            if (c != client)
                                c.Socket.Send(ms.GetBuffer());
                        }
                        break;
                }
            }
        }
    }
}
