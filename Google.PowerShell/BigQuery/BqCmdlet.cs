﻿// Copyright 2015-2016 Google Inc. All Rights Reserved.
// Licensed under the Apache License Version 2.0.

using Google.Apis.Bigquery.v2;
using Google.Cloud.BigQuery.V2;
using Google.PowerShell.Common;
using System;

namespace Google.PowerShell.BigQuery
{
    /// <summary>
    /// Base class for Google Cloud BigQuery cmdlets.
    /// </summary>
    public class BqCmdlet : GCloudCmdlet
    {
        private readonly Lazy<BigqueryService> _service;
        private readonly Lazy<BigQueryClient> _client;

        public BigqueryService Service => _service.Value;
        public BigQueryClient Client => _client.Value;

        public BqCmdlet()
        {
            //Service = new BigqueryService(GetBaseClientServiceInitializer());
            _service = new Lazy<BigqueryService>(() => new BigqueryService(GetBaseClientServiceInitializer()));
            _client = new Lazy<BigQueryClient>(() => BigQueryClient.Create(Project));
        }
    }
}
