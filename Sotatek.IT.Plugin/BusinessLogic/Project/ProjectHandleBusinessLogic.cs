using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Sotatek.IT.Plugin.BusinessLogic.Project
{
    public class ProjectHandleBusinessLogic
    {
        private readonly IPluginExecutionContext context;
        private readonly IOrganizationService service;
        private readonly ITracingService tracing;
        private readonly Entity entity;
        public ProjectHandleBusinessLogic(IPluginExecutionContext _context, IOrganizationService _service, ITracingService _tracing, Entity _entity)
        {
            context = _context;
            service = _service;
            tracing = _tracing;
            entity = _entity;
        }

        public void Excute1()
        {

        }
    }
}
