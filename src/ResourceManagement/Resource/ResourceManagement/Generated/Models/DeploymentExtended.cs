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
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Deployment information.
    /// </summary>
    public partial class DeploymentExtended
    {
        private string _id;
        
        /// <summary>
        /// Optional. Gets or sets the ID of the deployment.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name of the deployment.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private DeploymentPropertiesExtended _properties;
        
        /// <summary>
        /// Optional. Gets or sets deployment properties.
        /// </summary>
        public DeploymentPropertiesExtended Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class.
        /// </summary>
        public DeploymentExtended()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentExtended class with
        /// required arguments.
        /// </summary>
        public DeploymentExtended(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}