using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sotatek.Workflow.Action.Business.PushDataToAzureBlob
{
    public class PushDataToAzureBlobExcute
    {
        private readonly IOrganizationService service;
        private readonly ITracingService tracingService;
        public PushDataToAzureBlobExcute(IOrganizationService _service, ITracingService _tracingService)
        {
            service = _service;
            tracingService = _tracingService;
        }

        public void Excute1()
        {
            //Write code logic here
        }
    }
}
