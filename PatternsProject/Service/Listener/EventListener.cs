using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Listener
{
    public interface EventListener
    {
         void Update(string fileName);
    }
}
