using System;
using System.ServiceProcess;
using BeSafe.Core.ComponentsConfigurator;
using BeSafe.Core;
using Common.PipeCommandStructure;
using ExceptionManager;
using NamedPipeWrapper;
using ConfigManager;

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
            catch (Exception ex)
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
                            BeSafeConfig config = new BeSafeConfig(command.ConfigFilePath);
                            bool loadConfigResult = config.Load();

                            if(loadConfigResult)
                                ComponentRegulator.ManageComponentsState(config.ComponentsState);
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