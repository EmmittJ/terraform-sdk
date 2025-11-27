using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleComputeStoragePool.
/// Nesting mode: single
/// </summary>
public class GoogleComputeStoragePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_compute_storage_pool Terraform resource.
/// Manages a google_compute_storage_pool resource.
/// </summary>
public partial class GoogleComputeStoragePool(string name) : TerraformResource("google_compute_storage_pool", name)
{
    /// <summary>
    /// Provisioning type of the byte capacity of the pool. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    public TerraformValue<string> CapacityProvisioningType
    {
        get => new TerraformReference<string>(this, "capacity_provisioning_type");
        set => SetArgument("capacity_provisioning_type", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the StoragePool.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the StoragePool will fail.
    /// When the field is set to false, deleting the StoragePool is allowed.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// A description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Labels to apply to this storage pool. These can be later modified by the setLabels method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Provisioning type of the performance-related parameters of the pool, such as throughput and IOPS. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    public TerraformValue<string> PerformanceProvisioningType
    {
        get => new TerraformReference<string>(this, "performance_provisioning_type");
        set => SetArgument("performance_provisioning_type", value);
    }

    /// <summary>
    /// Size, in GiB, of the storage pool. For more information about the size limits,
    /// see https://cloud.google.com/compute/docs/disks/storage-pools.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedCapacityGb is required")]
    public required TerraformValue<string> PoolProvisionedCapacityGb
    {
        get => new TerraformReference<string>(this, "pool_provisioned_capacity_gb");
        set => SetArgument("pool_provisioned_capacity_gb", value);
    }

    /// <summary>
    /// Provisioned IOPS of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39;.
    /// </summary>
    public TerraformValue<string>? PoolProvisionedIops
    {
        get => new TerraformReference<string>(this, "pool_provisioned_iops");
        set => SetArgument("pool_provisioned_iops", value);
    }

    /// <summary>
    /// Provisioned throughput, in MB/s, of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39; or &#39;hyperdisk-throughput&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedThroughput is required")]
    public required TerraformValue<string> PoolProvisionedThroughput
    {
        get => new TerraformReference<string>(this, "pool_provisioned_throughput");
        set => SetArgument("pool_provisioned_throughput", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Type of the storage pool. For example, the
    /// following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/{project_id}/zones/{zone}/storagePoolTypes/hyperdisk-balanced&#39;
    /// * &#39;hyperdisk-throughput&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    public required TerraformValue<string> StoragePoolType
    {
        get => new TerraformReference<string>(this, "storage_pool_type");
        set => SetArgument("storage_pool_type", value);
    }

    /// <summary>
    /// A reference to the zone where the storage pool resides.
    /// </summary>
    public TerraformValue<string> Zone
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
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Type of the resource.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.
    /// Used internally during updates.
    /// </summary>
    public TerraformValue<string> LabelFingerprint
    {
        get => new TerraformReference<string>(this, "label_fingerprint");
    }

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourceStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resource_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeStoragePoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeStoragePoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
