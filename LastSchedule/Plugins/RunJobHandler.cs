using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixRM.LastSchedule.Plugins
{
    [CrmPluginRegistration(
    message: "fixrm_RunJob",
    entityLogicalName: "none",
    stage: StageEnum.PostOperation,
    executionMode: ExecutionModeEnum.Synchronous,
    filteringAttributes: null,
    stepName: "LastSchedule: RunJobHandler",
    executionOrder: 10,
    isolationModel: IsolationModeEnum.Sandbox)]
    public class RunJobHandler : IPlugin
    {
        #region Input parameters
        public static readonly string Target = "Target";
        #endregion

        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = serviceProvider.GetPluginExecutionContext();
            IOrganizationServiceFactory factory = serviceProvider.GetOrganizationServiceFactory();
            // Who is a caller in async process?
            IOrganizationService service = factory.CreateOrganizationService(context.InitiatingUserId);

            // Get input parameters
            EntityReference target = context.GetInputParameter<EntityReference>(Target);
            Entity job = service.Retrieve(target, "fixrm_query", "fixrm_processid");

            String query = job.GetAttributeValue<String>("fixrm_query");
            EntityReference processId = job.GetAttributeValue<EntityReference>("fixrm_processid");

            // No query means that process should be executed against job record itself
            if (string.IsNullOrEmpty(query))
            {
                service.Execute(new ExecuteWorkflowRequest()
                {
                    EntityId = target.Id,
                    WorkflowId = processId.Id
                });
            }
            // If job has query, process should be executed against each query result
            else
            {
                IEnumerable<Entity> results = service.RetrieveMultiple(new FetchExpression(query), null);

                foreach (Entity result in results)
                {
                    service.Execute(new ExecuteWorkflowRequest()
                    {
                        EntityId = result.Id,
                        WorkflowId = processId.Id
                    });
                }
            }
        }
    }
}
