// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

using System;
using System.Collections.Generic;
using log4net;
using System.Reflection;
using System.Collections.Concurrent;

namespace Microsoft.ServiceFabric.ReliableCollectionBackup.Parser
{
    /// <summary>
    /// ReliableCollectionChange stores the changes in a List during a transaction.
    /// </summary>
    public class ReliableCollectionChange
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Constructor of ReliableCollectionChange
        /// </summary>
        /// <param name="name">Name of Reliable Collection whose changes we are collecting.</param>
        public ReliableCollectionChange(Uri name)
        {
            this.Name = name;
            this.Changes = new ConcurrentQueue<EventArgs>();
        }

        /// <summary>
        /// Name of ReliableState
        /// </summary>
        public Uri Name { get; }

        /// <summary>
        /// List of changes that are received for this Reliable State.
        /// </summary>
        public ConcurrentQueue<EventArgs> Changes { get; }
    }
}
