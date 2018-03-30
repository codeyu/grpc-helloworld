using System;
using Grpc.Core;
using HelloWorldService;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new HelloWorld.HelloWorldClient(channel);
            var reply= client.SayHello(new HelloRequest { Name = "codeyu" });
            Console.WriteLine("Greeting: " + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
