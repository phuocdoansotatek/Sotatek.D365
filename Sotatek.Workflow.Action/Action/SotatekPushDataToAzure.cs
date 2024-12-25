using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;
using Sotatek.Workflow.Action.Business.PushDataToAzureBlob;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sotatek.Workflow.Action.Action
{
    public class SotatekPushDataToAzure : CodeActivity
    {
        [Input("Year")]
        [RequiredArgument]
        public InArgument<int> Year { get; set; }

        [Input("BU")]
        [RequiredArgument]
        public InArgument<string> BU { get; set; }


        [Output("JsonData")]
        public OutArgument<String> JsonData { get; set; }

        protected override void Execute(CodeActivityContext executionContext)
        {
            ITracingService tracer = executionContext.GetExtension<ITracingService>();
            IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
            IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
            IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);
            try
            {
                int year = Year.Get(executionContext);
                string bu = BU.Get(executionContext);

                PushDataToAzureBlobExcute Excute = new PushDataToAzureBlobExcute(service, tracer);
                Excute.Excute1();
                string _output = string.Empty;
                JsonData.Set(executionContext, _output);
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException(e.Message);
            }

        }
    }
}
