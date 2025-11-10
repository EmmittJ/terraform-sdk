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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    [TerraformPropertyName("storage_pool_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StoragePoolType { get; set; }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformPropertyName("zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Zone { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The deprecation status associated with this storage pool type.
    /// </summary>
    [TerraformPropertyName("deprecated")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Deprecated => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "deprecated");

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Id => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "id");

    /// <summary>
    /// Type of the resource. Always compute#storagePoolType for storage pool types.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// Maximum storage pool size in GB.
    /// </summary>
    [TerraformPropertyName("max_pool_provisioned_capacity_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxPoolProvisionedCapacityGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_pool_provisioned_capacity_gb");

    /// <summary>
    /// Maximum provisioned IOPS.
    /// </summary>
    [TerraformPropertyName("max_pool_provisioned_iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxPoolProvisionedIops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_pool_provisioned_iops");

    /// <summary>
    /// Maximum provisioned throughput.
    /// </summary>
    [TerraformPropertyName("max_pool_provisioned_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxPoolProvisionedThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_pool_provisioned_throughput");

    /// <summary>
    /// Minimum storage pool size in GB.
    /// </summary>
    [TerraformPropertyName("min_pool_provisioned_capacity_gb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinPoolProvisionedCapacityGb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_pool_provisioned_capacity_gb");

    /// <summary>
    /// Minimum provisioned IOPS.
    /// </summary>
    [TerraformPropertyName("min_pool_provisioned_iops")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinPoolProvisionedIops => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_pool_provisioned_iops");

    /// <summary>
    /// Minimum provisioned throughput.
    /// </summary>
    [TerraformPropertyName("min_pool_provisioned_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MinPoolProvisionedThroughput => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "min_pool_provisioned_throughput");

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    [TerraformPropertyName("self_link_with_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLinkWithId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link_with_id");

    /// <summary>
    /// The list of disk types supported in this storage pool type.
    /// </summary>
    [TerraformPropertyName("supported_disk_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedDiskTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_disk_types");

}
