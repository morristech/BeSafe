using System.ServiceProcess;

namespace BeSafe
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] servicesToRun = new ServiceBase[]
            {
                new ClientService.BeSafe()
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}