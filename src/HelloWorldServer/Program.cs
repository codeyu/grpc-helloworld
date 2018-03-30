using System;
using System.Threading.Tasks;
using Grpc.Core;
using HelloWorldService;
namespace HelloWorldServer
{
    class HelloWorldImpl : HelloWorld.HelloWorldBase
    {
        // 实现SayHello方法
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply { Message = "Hello " + request.Name });
        }
    }
    class Program
    {
        const int Port = 50051;
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { HelloWorld.BindService(new HelloWorldImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Greeter server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}
