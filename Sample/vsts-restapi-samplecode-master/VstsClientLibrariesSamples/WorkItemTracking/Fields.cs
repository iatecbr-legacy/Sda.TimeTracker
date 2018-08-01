﻿using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;

namespace VstsClientLibrariesSamples.WorkItemTracking
{
    public class Fields
    {
        readonly IConfiguration _configuration;
        private VssBasicCredential _credentials;
        private Uri _uri;

        public Fields(IConfiguration configuration)
        {
            _configuration = configuration;
            _credentials = new VssBasicCredential("", _configuration.PersonalAccessToken);
            _uri = new Uri(_configuration.UriString);
        }

        public string GetListOfWorkItemFields(string fieldName)
        {
            VssConnection connection = new VssConnection(_uri, _credentials);
            WorkItemTrackingHttpClient workItemTrackingHttpClient = connection.GetClient<WorkItemTrackingHttpClient>();
            List<WorkItemField> result = workItemTrackingHttpClient.GetFieldsAsync(null).Result;

            var item = result.Find(x => x.Name == fieldName);

            if (item == null)
            {
                return "field not found";
            }
            else
            {
                return item.ReferenceName;
            }         
        }
    }
}
