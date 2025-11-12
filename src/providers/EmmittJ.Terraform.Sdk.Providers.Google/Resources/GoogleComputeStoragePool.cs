using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeStoragePoolTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_storage_pool resource.
/// </summary>
public partial class GoogleComputeStoragePool : TerraformResource
{
    public GoogleComputeStoragePool(string name) : base("google_compute_storage_pool", name)
    {
    }

    /// <summary>
    /// Provisioning type of the byte capacity of the pool. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    [TerraformProperty("capacity_provisioning_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CapacityProvisioningType { get; set; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the StoragePool.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the StoragePool will fail.
    /// When the field is set to false, deleting the StoragePool is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// A description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Labels to apply to this storage pool. These can be later modified by the setLabels method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Name of the resource. Provided by the client when the resource is created.
    /// The name must be 1-63 characters long, and comply with RFC1035.
    /// Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39;
    /// which means the first character must be a lowercase letter,
    /// and all following characters must be a dash, lowercase letter, or digit,
    /// except the last character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Provisioning type of the performance-related parameters of the pool, such as throughput and IOPS. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    [TerraformProperty("performance_provisioning_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PerformanceProvisioningType { get; set; }

    /// <summary>
    /// Size, in GiB, of the storage pool. For more information about the size limits,
    /// see https://cloud.google.com/compute/docs/disks/storage-pools.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedCapacityGb is required")]
    [TerraformProperty("pool_provisioned_capacity_gb")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PoolProvisionedCapacityGb { get; set; }

    /// <summary>
    /// Provisioned IOPS of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39;.
    /// </summary>
    [TerraformProperty("pool_provisioned_iops")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PoolProvisionedIops { get; set; }

    /// <summary>
    /// Provisioned throughput, in MB/s, of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39; or &#39;hyperdisk-throughput&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedThroughput is required")]
    [TerraformProperty("pool_provisioned_throughput")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PoolProvisionedThroughput { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Type of the storage pool. For example, the
    /// following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/{project_id}/zones/{zone}/storagePoolTypes/hyperdisk-balanced&#39;
    /// * &#39;hyperdisk-throughput&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    [TerraformProperty("storage_pool_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StoragePoolType { get; set; }

    /// <summary>
    /// A reference to the zone where the storage pool resides.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleComputeStoragePoolTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// Type of the resource.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.
    /// Used internally during updates.
    /// </summary>
    [TerraformProperty("label_fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LabelFingerprint { get; }

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    [TerraformProperty("resource_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ResourceStatus { get; }

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
