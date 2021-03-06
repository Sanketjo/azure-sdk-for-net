// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Base for all lists of resources.
    /// </summary>
    public partial class ResourceList
    {
        /// <summary>
        /// Initializes a new instance of the ResourceList class.
        /// </summary>
        public ResourceList() { }

        /// <summary>
        /// Initializes a new instance of the ResourceList class.
        /// </summary>
        /// <param name="nextLink">The uri to fetch the next page of
        /// resources. Call ListNext() fetches next page of resources.</param>
        public ResourceList(string nextLink = default(string))
        {
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets the uri to fetch the next page of resources. Call
        /// ListNext() fetches next page of resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
