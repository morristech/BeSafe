using System;
using NamedPipeWrapper;
using ExceptionManager;
using ClientUI.Properties;
using Common.PipeCommandStructure;
using Common.Utils;

namespace ClientUI.Core
{
    public class PipeClient
    {
        public event ConnectionMessageEventHandler<BeSafePipeCommand, BeSafePipeCommand> ServerMessageEventHandler;

        private NamedPipeClient<BeSafePipeCommand> pipeClient = new NamedPipeClient<BeSafePipeCommand>(Resources.ApplicationName);    

        public void Start()
        {
            pipeClient.Error += OnError;
            pipeClient.ServerMessage += ServerMessageEventHandler;
            pipeClient.Start();
        }

        public void Stop()
        {
            pipeClient.Stop();
        }

        private void OnError(Exception exception)
        {
            exception.Log();
        }

        public bool SendCommandToService(BeSafePipeCommand command)
        {
            try
            {
                command.ConfigFilePath = PathUtils.ConfigFilePath;
                pipeClient.PushMessage(command);
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