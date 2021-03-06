// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{

    /// <summary>
    /// Defines values for DataSourceType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataSourceType
    {
        [System.Runtime.Serialization.EnumMember(Value = "Invalid")]
        Invalid,
        [System.Runtime.Serialization.EnumMember(Value = "VM")]
        VM,
        [System.Runtime.Serialization.EnumMember(Value = "FileFolder")]
        FileFolder,
        [System.Runtime.Serialization.EnumMember(Value = "AzureSqlDb")]
        AzureSqlDb,
        [System.Runtime.Serialization.EnumMember(Value = "SQLDB")]
        SQLDB,
        [System.Runtime.Serialization.EnumMember(Value = "Exchange")]
        Exchange,
        [System.Runtime.Serialization.EnumMember(Value = "Sharepoint")]
        Sharepoint,
        [System.Runtime.Serialization.EnumMember(Value = "DPMUnknown")]
        DPMUnknown
    }
}
