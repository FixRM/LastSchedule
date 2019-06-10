using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixRM.LastSchedule.Plugins
{
    public class GetNextRecurrenceHandler : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = serviceProvider.GetPluginExecutionContext();
        }
    }
}
