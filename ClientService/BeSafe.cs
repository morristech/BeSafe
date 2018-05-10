using System.ServiceProcess;
using Common;
using ExceptionManager;

namespace ClientService
{
    public partial class BeSafe : ServiceBase
    {
        public BeSafe()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                ex.Log();
            }
        }

        protected override void OnStop()
        {

        }
    }
}