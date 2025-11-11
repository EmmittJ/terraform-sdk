using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeStoragePoolTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_compute_storage_pool resource.
/// </summary>
public class GoogleComputeStoragePool : TerraformResource
{
    public GoogleComputeStoragePool(string name) : base("google_compute_storage_pool", name)
    {
    }

    /// <summary>
    /// Provisioning type of the byte capacity of the pool. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("capacity_provisioning_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> CapacityProvisioningType { get; set; } = default!;

    /// <summary>
    /// Whether Terraform will be prevented from destroying the StoragePool.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the StoragePool will fail.
    /// When the field is set to false, deleting the StoragePool is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// A description of this resource. Provide this property when you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Labels to apply to this storage pool. These can be later modified by the setLabels method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Provisioning type of the performance-related parameters of the pool, such as throughput and IOPS. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("performance_provisioning_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PerformanceProvisioningType { get; set; } = default!;

    /// <summary>
    /// Size, in GiB, of the storage pool. For more information about the size limits,
    /// see https://cloud.google.com/compute/docs/disks/storage-pools.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedCapacityGb is required")]
    [TerraformPropertyName("pool_provisioned_capacity_gb")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PoolProvisionedCapacityGb { get; set; }

    /// <summary>
    /// Provisioned IOPS of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39;.
    /// </summary>
    [TerraformPropertyName("pool_provisioned_iops")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PoolProvisionedIops { get; set; }

    /// <summary>
    /// Provisioned throughput, in MB/s, of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39; or &#39;hyperdisk-throughput&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedThroughput is required")]
    [TerraformPropertyName("pool_provisioned_throughput")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PoolProvisionedThroughput { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Type of the storage pool. For example, the
    /// following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/{project_id}/zones/{zone}/storagePoolTypes/hyperdisk-balanced&#39;
    /// * &#39;hyperdisk-throughput&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    [TerraformPropertyName("storage_pool_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StoragePoolType { get; set; }

    /// <summary>
    /// A reference to the zone where the storage pool resides.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Zone { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeStoragePoolTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// Type of the resource.
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Kind => new TerraformReference(this, "kind");

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.
    /// Used internally during updates.
    /// </summary>
    [TerraformPropertyName("label_fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LabelFingerprint => new TerraformReference(this, "label_fingerprint");

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    [TerraformPropertyName("resource_status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ResourceStatus => new TerraformReference(this, "resource_status");

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
