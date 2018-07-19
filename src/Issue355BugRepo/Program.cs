using System;
using Renci.SshNet;

namespace Issue355BugRepo
{
    class Program
    {
        private const string Host = "TEST";
        private const string Username = "TEST";
        private const string Password = "TEST"; 
        
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Starting");

            using (var sftpClient = new SftpClient(Host, Username, Password))
            {
                Console.WriteLine("2. Connecting");
                
                sftpClient.Connect();
                
                Console.WriteLine("3. Connected");
                
                //DO STUFF
                
                Console.WriteLine("4. Disconnecting");
                
                sftpClient.Disconnect();
                
                Console.WriteLine("5. Disconnected");
            }
            
            Console.WriteLine("6. Finished");
        }
    }
}