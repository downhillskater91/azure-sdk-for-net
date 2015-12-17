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
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition of a CommonJobQueryFilter object.
    /// </summary>
    public partial class CommonJobQueryFilters : JobQueryFilters
    {
        private string _backupManagementType;
        
        /// <summary>
        /// Optional. Type query parameter
        /// </summary>
        public string BackupManagementType
        {
            get { return this._backupManagementType; }
            set { this._backupManagementType = value; }
        }
        
        private string _endTime;
        
        /// <summary>
        /// Optional. EndTime query parameter
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private string _jobId;
        
        /// <summary>
        /// Optional. JobId query parameter
        /// </summary>
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }
        
        private string _operation;
        
        /// <summary>
        /// Optional. Operation query parameter
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }
        
        private string _startTime;
        
        /// <summary>
        /// Optional. StartTime query parameter
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Status query parameter
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CommonJobQueryFilters class.
        /// </summary>
        public CommonJobQueryFilters()
        {
        }
    }
}
