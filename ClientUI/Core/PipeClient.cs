using System;
using NamedPipeWrapper;
using ExceptionManager;
using ClientUI.Properties;
using Common.PipeCommandStructure;

namespace ClientUI.Core
{
    public class PipeClient
    {
        public event ConnectionMessageEventHandler<BeSafePipeCommand, BeSafePipeCommand> ServerMessageEventHandler;

        private NamedPipeClient<BeSafePipeCommand> client = new NamedPipeClient<BeSafePipeCommand>(Resources.ApplicationName);

        public PipeClient()
        {
            client.Error += OnError;
            client.ServerMessage += ServerMessageEventHandler;

            client.Start();
        }      

        private void OnError(Exception exception)
        {
            exception.Log();
        }

        public bool SendCommandToService(BeSafePipeCommand command)
        {
            try
            {
                client.PushMessage(command);
                return true;
            }
            catch (Exception ex)
            {
                ex.Log();
            }

            return false;
        }
    }
}