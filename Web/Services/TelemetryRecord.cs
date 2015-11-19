// ---------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

namespace Microsoft.Azure.Devices.Applications.PredictiveMaintenance.Web.Services
{
    using WindowsAzure.Storage.Table;

    public sealed class TelemetryRecord : TableEntity
    {
        public string sensor11 { get; set; }

        public string sensor14 { get; set; }

        public string sensor15 { get; set; }

        public string sensor9 { get; set; }
    }
}