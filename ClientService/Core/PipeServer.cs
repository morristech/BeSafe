using System;
using NamedPipeWrapper;
using ExceptionManager;
using Common.PipeCommandStructure;
using BeSafe.Properties;

namespace BeSafe.Core
{
    public class PipeServer
    {
        public event ConnectionMessageEventHandler<BeSafePipeCommand, BeSafePipeCommand> ClientMessageEventHandler;

        private NamedPipeServer<BeSafePipeCommand> server = new NamedPipeServer<BeSafePipeCommand>(Resources.ApplicationName);;

        public void Start()
        {
            server.Error += OnError;
            server.ClientConnected += OnClientConnected;
            server.ClientMessage += ClientMessageEventHandler;
            server.Start();
        }

        private void OnClientConnected(NamedPipeConnection<BeSafePipeCommand, BeSafePipeCommand> connection)
        {
    
        }

        private void OnError(Exception exception)
        {
            exception.Log();
        }

        public bool SendCommandToUI(BeSafePipeCommand command)
        {
            try
            {
                server.PushMessage(command);
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