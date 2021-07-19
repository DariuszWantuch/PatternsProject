using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Listener
{
    public class EventManager
    {
        private Dictionary<string, List<LoggingListener>> listeners = new Dictionary<string, List<LoggingListener>>();

        public void AddEvent(string eventType, LoggingListener listener)
        {
            if (listeners.ContainsKey(eventType))
            {
                listeners[eventType].Add(listener);
            }
            else
            {
                var list = new List<LoggingListener>();
                list.Add(listener);
                listeners.Add(eventType, list);
            }
            
        }
              
        public void UpdateFiles(string eventType, string data)
        {
            var listLogger = listeners.Where(x => x.Key == eventType).Select(x => x.Value).ToList();

            foreach (var list in listLogger)
            {
                foreach (var item in list)
                {
                    item.Update(data);
                }
                
            }
        }
    }
}
