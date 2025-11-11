using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_storage_pool_types.
/// </summary>
public class GoogleComputeStoragePoolTypesDataSource : TerraformDataSource
{
    public GoogleComputeStoragePoolTypesDataSource(string name) : base("google_compute_storage_pool_types", name)
    {
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    [TerraformPropertyName("storage_pool_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StoragePoolType { get; set; }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformPropertyName("zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// The deprecation status associated with this storage pool type.
    /// </summary>
    [TerraformPropertyName("deprecated")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Deprecated => new TerraformReference(this, "deprecated");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Id => new TerraformReference(this, "id");

    /// <summary>
    /// Type of the resource. Always compute#storagePoolType for storage pool types.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// Maximum storage pool size in GB.
    /// </summary>
    [TerraformPropertyName("max_pool_provisioned_capacity_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxPoolProvisionedCapacityGb => new TerraformReference(this, "max_pool_provisioned_capacity_gb");

    /// <summary>
    /// Maximum provisioned IOPS.
    /// </summary>
    [TerraformPropertyName("max_pool_provisioned_iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxPoolProvisionedIops => new TerraformReference(this, "max_pool_provisioned_iops");

    /// <summary>
    /// Maximum provisioned throughput.
    /// </summary>
    [TerraformPropertyName("max_pool_provisioned_throughput")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxPoolProvisionedThroughput => new TerraformReference(this, "max_pool_provisioned_throughput");

    /// <summary>
    /// Minimum storage pool size in GB.
    /// </summary>
    [TerraformPropertyName("min_pool_provisioned_capacity_gb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinPoolProvisionedCapacityGb => new TerraformReference(this, "min_pool_provisioned_capacity_gb");

    /// <summary>
    /// Minimum provisioned IOPS.
    /// </summary>
    [TerraformPropertyName("min_pool_provisioned_iops")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinPoolProvisionedIops => new TerraformReference(this, "min_pool_provisioned_iops");

    /// <summary>
    /// Minimum provisioned throughput.
    /// </summary>
    [TerraformPropertyName("min_pool_provisioned_throughput")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MinPoolProvisionedThroughput => new TerraformReference(this, "min_pool_provisioned_throughput");

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    [TerraformPropertyName("self_link_with_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLinkWithId => new TerraformReference(this, "self_link_with_id");

    /// <summary>
    /// The list of disk types supported in this storage pool type.
    /// </summary>
    [TerraformPropertyName("supported_disk_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedDiskTypes => new TerraformReference(this, "supported_disk_types");

}
