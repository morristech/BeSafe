using System;
using NamedPipeWrapper;
using ExceptionManager;
using Common.PipeCommandStructure;
using BeSafe.Properties;

namespace BeSafe.Core.Utils
{
    public class PipeServer
    {
        public event ConnectionMessageEventHandler<BeSafePipeCommand, BeSafePipeCommand> ClientMessageEventHandler;

        private readonly NamedPipeServer<BeSafePipeCommand> _serverPipe = new NamedPipeServer<BeSafePipeCommand>(Resources.ApplicationName);

        public void Start()
        {
            _serverPipe.Error += OnError;
            _serverPipe.ClientConnected += OnClientConnected;
            _serverPipe.ClientMessage += ClientMessageEventHandler;
            _serverPipe.Start();
        }

        public void Stop()
        {
            _serverPipe.Stop();
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
                _serverPipe.PushMessage(command);
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