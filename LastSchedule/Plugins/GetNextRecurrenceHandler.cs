using Microsoft.Xrm.Sdk;
using Quartz;
using System;

namespace FixRM.LastSchedule.Plugins
{
    [CrmPluginRegistration(
        message: "fixrm_GetNextRecurrence",
        entityLogicalName: "none",
        stage: StageEnum.PostOperation,
        executionMode: ExecutionModeEnum.Synchronous,
        filteringAttributes: null,
        stepName: "LastSchedule: GetNextRecurrenceHandler",
        executionOrder: 10,
        isolationModel: IsolationModeEnum.Sandbox)]
    public class GetNextRecurrenceHandler : IPlugin
    {
        public static readonly string Target = "Target";
        public static readonly string NextRecurrence = "NextRecurrence";

        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = serviceProvider.GetPluginExecutionContext();
            IOrganizationServiceFactory serviceFactory = serviceProvider.GetOrganizationServiceFactory();
            // Who is a caller in async process?
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);

            // Get input parameters
            EntityReference jobReference = context.GetInputParameter<EntityReference>(Target);
            Entity job = service.Retrieve(jobReference, "fixrm_scheduleid");

            // Get schedule
            EntityReference scheduleReference = job.GetAttributeValue<EntityReference>("fixrm_scheduleid");
            Entity schedule = service.Retrieve(scheduleReference, "fixrm_pattern");

            // Get recurrence pattern
            string pattern = schedule.GetAttributeValue<string>("fixrm_pattern");
            CronExpression recurrence = new CronExpression(pattern);

            // Calculate next occurrence date and set output parameters
            // From last run?
            DateTimeOffset? nextRun = recurrence.GetTimeAfter(DateTimeOffset.UtcNow);
            context.OutputParameters[NextRecurrence] = nextRun?.UtcDateTime;
        }
    }
}
