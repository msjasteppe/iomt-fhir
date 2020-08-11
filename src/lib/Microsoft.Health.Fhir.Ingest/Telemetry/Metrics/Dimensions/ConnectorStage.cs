﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Ingest.Telemetry
{
    public static class ConnectorStage
    {
        /// <summary>
        /// The setup stage of the IoMT Connector
        /// </summary>
        public static string Setup => nameof(ConnectorStage.Setup);

        /// <summary>
        /// The normalization stage of the IoMT Connector
        /// </summary>
        public static string Normalization => nameof(ConnectorStage.Normalization);

        /// <summary>
        /// The grouping stage of the IoMT Connector
        /// </summary>
        public static string Grouping => nameof(ConnectorStage.Grouping);

        /// <summary>
        /// The FHIR conversion stage of the IoMT Connector
        /// </summary>
        public static string FHIRConversion => nameof(ConnectorStage.FHIRConversion);

        /// <summary>
        /// If a stage is not determined.
        /// </summary>
        public static string Unknown => nameof(ConnectorStage.Unknown);
    }
}
