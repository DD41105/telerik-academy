using System;

namespace ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        { 
            //input
            string input = Console.ReadLine();

            //algorithm
            //get protocol
            int indexProtocol = input.IndexOf(':');
            string protocol = input.Substring(0, indexProtocol);
            input = input.Remove(0, indexProtocol + 3); //remove protocol + ':' and "//" from string
            //get sever
            int indexSever = input.IndexOf('/');
            string server = input.Substring(0, indexSever);
            input = input.Remove(0, indexSever); //remove server from string
            //get resource
            string resource = input;

            //print
            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);
        }
    }
}