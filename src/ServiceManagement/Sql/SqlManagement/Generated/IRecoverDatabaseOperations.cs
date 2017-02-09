// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// Contains the operation to create recovery requests for Azure SQL
    /// Databases.
    /// </summary>
    public partial interface IRecoverDatabaseOperations
    {
        /// <summary>
        /// Issues a recovery request for an Azure SQL Database.
        /// </summary>
        /// <param name='sourceServerName'>
        /// The name of the Azure SQL Database Server on which the database was
        /// hosted.
        /// </param>
        /// <param name='parameters'>
        /// Additional parameters for the Create Recover Database Operation
        /// request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Contains the response to the Create Recover Database Operation
        /// request.
        /// </returns>
        Task<RecoverDatabaseOperationCreateResponse> CreateAsync(string sourceServerName, RecoverDatabaseOperationCreateParameters parameters, CancellationToken cancellationToken);
    }
}