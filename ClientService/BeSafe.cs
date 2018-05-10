using System;
using System.ServiceProcess;
using BeSafe.ComponentsConfigurator;
using BeSafe.Core;
using Common.PipeCommandStructure;
using ExceptionManager;
using NamedPipeWrapper;

namespace ClientService
{
    public partial class BeSafe : ServiceBase
    {
        private readonly PipeServer pipeServer = new PipeServer();

        public BeSafe()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                pipeServer.ClientMessageEventHandler += OnClientCommandReceived;
                pipeServer.Start();
            }
            catch (System.Exception ex)
            {
                ex.Log();
            }
        }

        protected override void OnStop()
        {
            pipeServer.Stop();
        }

        private void OnClientCommandReceived(NamedPipeConnection<BeSafePipeCommand, BeSafePipeCommand> connection, BeSafePipeCommand command)
        {
            try
            {
                switch (command.Command)
                {
                    case PipeCommands.ComponentConfiguration:
                        {
                            ConfigManager.ManageComponentsState(command.ComponentsState);
                        }
                        break;

                    case PipeCommands.ReloadPlugins:
                        {

                        }
                        break;

                    case PipeCommands.Notification:
                        {

                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                ex.Log();
            }
        }
    }
}