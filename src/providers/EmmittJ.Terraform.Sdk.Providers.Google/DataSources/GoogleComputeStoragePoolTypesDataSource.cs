using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_storage_pool_types Terraform data source.
/// Retrieves information about a google_compute_storage_pool_types.
/// </summary>
public partial class GoogleComputeStoragePoolTypesDataSource(string name) : TerraformDataSource("google_compute_storage_pool_types", name)
{
    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    public required TerraformValue<string> StoragePoolType
    {
        get => GetArgument<TerraformValue<string>>("storage_pool_type");
        set => SetArgument("storage_pool_type", value);
    }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// The deprecation status associated with this storage pool type.
    /// </summary>
    public TerraformList<TerraformMap<object>> Deprecated
        => AsReference("deprecated");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> Id
        => AsReference("id");

    /// <summary>
    /// Type of the resource. Always compute#storagePoolType for storage pool types.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// Maximum storage pool size in GB.
    /// </summary>
    public TerraformValue<double> MaxPoolProvisionedCapacityGb
        => AsReference("max_pool_provisioned_capacity_gb");

    /// <summary>
    /// Maximum provisioned IOPS.
    /// </summary>
    public TerraformValue<double> MaxPoolProvisionedIops
        => AsReference("max_pool_provisioned_iops");

    /// <summary>
    /// Maximum provisioned throughput.
    /// </summary>
    public TerraformValue<double> MaxPoolProvisionedThroughput
        => AsReference("max_pool_provisioned_throughput");

    /// <summary>
    /// Minimum storage pool size in GB.
    /// </summary>
    public TerraformValue<double> MinPoolProvisionedCapacityGb
        => AsReference("min_pool_provisioned_capacity_gb");

    /// <summary>
    /// Minimum provisioned IOPS.
    /// </summary>
    public TerraformValue<double> MinPoolProvisionedIops
        => AsReference("min_pool_provisioned_iops");

    /// <summary>
    /// Minimum provisioned throughput.
    /// </summary>
    public TerraformValue<double> MinPoolProvisionedThroughput
        => AsReference("min_pool_provisioned_throughput");

    /// <summary>
    /// Name of the resource.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformValue<string> SelfLinkWithId
        => AsReference("self_link_with_id");

    /// <summary>
    /// The list of disk types supported in this storage pool type.
    /// </summary>
    public TerraformList<string> SupportedDiskTypes
        => AsReference("supported_disk_types");

}
