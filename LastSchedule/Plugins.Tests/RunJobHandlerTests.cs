using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeXrmEasy;
using FixRM.LastSchedule.Plugins.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;

namespace FixRM.LastSchedule.Plugins.Tests
{
    [TestClass]
    public class RunJobHandlerTests
    {
        /// <summary>
        /// No query means that process should be executed against job record itself
        /// </summary>
        [TestMethod]
        public void No_Query_Test()
        {
            // Setup
            string fetchXml = null;
            EntityReference process = new EntityReference("workflow", Guid.NewGuid());

            fixrm_RecurringJob job = new fixrm_RecurringJob()
            {
                Id = Guid.NewGuid(),
                fixrm_Query = fetchXml,
                fixrm_ProcessId = process
            };

            XrmFakedContext fakedContext = new XrmFakedContext();
            fakedContext.Initialize(new Entity[] { job });

            ExecuteWorkflowRequest request = null;
            fakedContext.AddExecutionMock<ExecuteWorkflowRequest>((orgRequest) =>
            {
                request = orgRequest as ExecuteWorkflowRequest;

                return new ExecuteWorkflowResponse();
            });

            XrmFakedPluginExecutionContext executionContext = fakedContext.GetDefaultPluginContext();
            executionContext.InputParameters.Add(RunJobHandler.Target, job.ToEntityReference());

            // Act
            fakedContext.ExecutePluginWith<RunJobHandler>(executionContext);

            // Assert
            Assert.AreEqual(job.Id, request.EntityId);
            Assert.AreEqual(process.Id, request.WorkflowId);
        }

        /// <summary>
        /// If job has query, process should be executed against each query result
        /// </summary>
        [TestMethod]
        public void Query_Test()
        {
            // Setup
            string fetchXml =
                @"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false' page='0'>
                  <entity name='account' />
                </fetch>";

            EntityReference process = new EntityReference("workflow", Guid.NewGuid());

            Entity job = new Entity()
            {
                Id = Guid.NewGuid(),
                LogicalName = fixrm_RecurringJob.EntityLogicalName,
                ["fixrm_query"] = fetchXml,
                ["fixrm_processid"] = process
            };

            /// One entity is enough as we are not testing
            /// query itself
            Entity account = new Entity()
            {
                Id = Guid.NewGuid(),
                LogicalName = "account"
            };

            XrmFakedContext fakedContext = new XrmFakedContext();
            fakedContext.Initialize(new Entity[] { job, account });

            ExecuteWorkflowRequest request = null;
            fakedContext.AddExecutionMock<ExecuteWorkflowRequest>((orgRequest) =>
            {
                request = orgRequest as ExecuteWorkflowRequest;

                return new ExecuteWorkflowResponse();
            });

            XrmFakedPluginExecutionContext executionContext = fakedContext.GetDefaultPluginContext();
            executionContext.InputParameters.Add(RunJobHandler.Target, job.ToEntityReference());

            // Act
            fakedContext.ExecutePluginWith<RunJobHandler>(executionContext);

            // Assert
            Assert.AreEqual(account.Id, request.EntityId);
            Assert.AreEqual(process.Id, request.WorkflowId);
        }
    }
}
