using System;
using System.Threading;
using System.Threading.Tasks;
using NetCore20.Services;

namespace NetCore20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your storm troopers provider!");

            Console.WriteLine("Storm Troopers available:");

            using(StormTrooperService service = new StormTrooperService())
            {
                var stormTroopersTask = service.GetAllAsync(CancellationToken.None).GetAwaiter().GetResult();

                System.Console.WriteLine(stormTroopersTask);
            }
        }
    }
}
