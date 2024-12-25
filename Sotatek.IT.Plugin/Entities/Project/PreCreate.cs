using Microsoft.Xrm.Sdk;
using Sotatek.IT.Plugin.BusinessLogic.Project;
using System;

namespace Sotatek.IT.Plugin.Entities.Project
{
    public class PreCreate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            IPluginExecutionContext context = (IPluginExecutionContext)
                        serviceProvider.GetService(typeof(IPluginExecutionContext));
            ITracingService tracing = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                Entity entity = (Entity)context.InputParameters["Target"];
                if (entity.LogicalName != "Entity Project") return;

                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                ProjectHandleBusinessLogic excuteLogic = new ProjectHandleBusinessLogic(context, service, tracing, entity);
                excuteLogic.Excute1();
            }
        }
    }
}
