using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_storage_pool_types.
/// </summary>
public partial class GoogleComputeStoragePoolTypesDataSource : TerraformDataSource
{
    public GoogleComputeStoragePoolTypesDataSource(string name) : base("google_compute_storage_pool_types", name)
    {
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    [TerraformProperty("storage_pool_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StoragePoolType { get; set; }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    [TerraformProperty("zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The deprecation status associated with this storage pool type.
    /// </summary>
    [TerraformProperty("deprecated")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Deprecated { get; }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Id { get; }

    /// <summary>
    /// Type of the resource. Always compute#storagePoolType for storage pool types.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// Maximum storage pool size in GB.
    /// </summary>
    [TerraformProperty("max_pool_provisioned_capacity_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxPoolProvisionedCapacityGb { get; }

    /// <summary>
    /// Maximum provisioned IOPS.
    /// </summary>
    [TerraformProperty("max_pool_provisioned_iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxPoolProvisionedIops { get; }

    /// <summary>
    /// Maximum provisioned throughput.
    /// </summary>
    [TerraformProperty("max_pool_provisioned_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxPoolProvisionedThroughput { get; }

    /// <summary>
    /// Minimum storage pool size in GB.
    /// </summary>
    [TerraformProperty("min_pool_provisioned_capacity_gb")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinPoolProvisionedCapacityGb { get; }

    /// <summary>
    /// Minimum provisioned IOPS.
    /// </summary>
    [TerraformProperty("min_pool_provisioned_iops")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinPoolProvisionedIops { get; }

    /// <summary>
    /// Minimum provisioned throughput.
    /// </summary>
    [TerraformProperty("min_pool_provisioned_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MinPoolProvisionedThroughput { get; }

    /// <summary>
    /// Name of the resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    [TerraformProperty("self_link_with_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLinkWithId { get; }

    /// <summary>
    /// The list of disk types supported in this storage pool type.
    /// </summary>
    [TerraformProperty("supported_disk_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedDiskTypes { get; }

}
