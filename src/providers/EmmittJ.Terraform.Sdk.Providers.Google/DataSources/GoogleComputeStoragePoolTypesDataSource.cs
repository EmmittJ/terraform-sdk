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
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    public required TerraformValue<string> StoragePoolType
    {
        get => new TerraformReference<string>(this, "storage_pool_type");
        set => SetArgument("storage_pool_type", value);
    }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// The deprecation status associated with this storage pool type.
    /// </summary>
    public TerraformList<TerraformMap<object>> Deprecated
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "deprecated").ResolveNodes(ctx));
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> Id
    {
        get => new TerraformReference<double>(this, "id");
    }

    /// <summary>
    /// Type of the resource. Always compute#storagePoolType for storage pool types.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// Maximum storage pool size in GB.
    /// </summary>
    public TerraformValue<double> MaxPoolProvisionedCapacityGb
    {
        get => new TerraformReference<double>(this, "max_pool_provisioned_capacity_gb");
    }

    /// <summary>
    /// Maximum provisioned IOPS.
    /// </summary>
    public TerraformValue<double> MaxPoolProvisionedIops
    {
        get => new TerraformReference<double>(this, "max_pool_provisioned_iops");
    }

    /// <summary>
    /// Maximum provisioned throughput.
    /// </summary>
    public TerraformValue<double> MaxPoolProvisionedThroughput
    {
        get => new TerraformReference<double>(this, "max_pool_provisioned_throughput");
    }

    /// <summary>
    /// Minimum storage pool size in GB.
    /// </summary>
    public TerraformValue<double> MinPoolProvisionedCapacityGb
    {
        get => new TerraformReference<double>(this, "min_pool_provisioned_capacity_gb");
    }

    /// <summary>
    /// Minimum provisioned IOPS.
    /// </summary>
    public TerraformValue<double> MinPoolProvisionedIops
    {
        get => new TerraformReference<double>(this, "min_pool_provisioned_iops");
    }

    /// <summary>
    /// Minimum provisioned throughput.
    /// </summary>
    public TerraformValue<double> MinPoolProvisionedThroughput
    {
        get => new TerraformReference<double>(this, "min_pool_provisioned_throughput");
    }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformValue<string> SelfLinkWithId
    {
        get => new TerraformReference<string>(this, "self_link_with_id");
    }

    /// <summary>
    /// The list of disk types supported in this storage pool type.
    /// </summary>
    public TerraformList<string> SupportedDiskTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_disk_types").ResolveNodes(ctx));
    }

}
