using PatternsProject.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Listener
{
    public class LoggingListener : EventListener
    {      
        private string message;

        public LoggingListener( string message)
        {           
            this.message = message;
        }

        public void Update(string fileName)
        {
            File.AppendAllText(PathOptions.LogFiles + fileName, DateTime.Now.ToString("HH:mm:ss : ") + message + "\n");
        }      
    }
}
