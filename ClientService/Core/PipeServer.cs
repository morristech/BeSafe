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

        private NamedPipeServer<BeSafePipeCommand> serverPipe = new NamedPipeServer<BeSafePipeCommand>(Resources.ApplicationName);

        public void Start()
        {
            serverPipe.Error += OnError;
            serverPipe.ClientConnected += OnClientConnected;
            serverPipe.ClientMessage += ClientMessageEventHandler;
            serverPipe.Start();
        }

        public void Stop()
        {
            serverPipe.Stop();
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
                serverPipe.PushMessage(command);
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