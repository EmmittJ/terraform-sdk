using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeStoragePoolTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_compute_storage_pool resource.
/// </summary>
public class GoogleComputeStoragePool : TerraformResource
{
    public GoogleComputeStoragePool(string name) : base("google_compute_storage_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_timestamp");
        SetOutput("effective_labels");
        SetOutput("id");
        SetOutput("kind");
        SetOutput("label_fingerprint");
        SetOutput("resource_status");
        SetOutput("status");
        SetOutput("terraform_labels");
        SetOutput("capacity_provisioning_type");
        SetOutput("deletion_protection");
        SetOutput("description");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("performance_provisioning_type");
        SetOutput("pool_provisioned_capacity_gb");
        SetOutput("pool_provisioned_iops");
        SetOutput("pool_provisioned_throughput");
        SetOutput("project");
        SetOutput("storage_pool_type");
        SetOutput("zone");
    }

    /// <summary>
    /// Provisioning type of the byte capacity of the pool. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> CapacityProvisioningType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("capacity_provisioning_type");
        set => SetProperty("capacity_provisioning_type", value);
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the StoragePool.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the StoragePool will fail.
    /// When the field is set to false, deleting the StoragePool is allowed.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// A description of this resource. Provide this property when you create the resource.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Labels to apply to this storage pool. These can be later modified by the setLabels method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Provisioning type of the performance-related parameters of the pool, such as throughput and IOPS. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> PerformanceProvisioningType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("performance_provisioning_type");
        set => SetProperty("performance_provisioning_type", value);
    }

    /// <summary>
    /// Size, in GiB, of the storage pool. For more information about the size limits,
    /// see https://cloud.google.com/compute/docs/disks/storage-pools.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedCapacityGb is required")]
    public required TerraformProperty<string> PoolProvisionedCapacityGb
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pool_provisioned_capacity_gb");
        set => SetProperty("pool_provisioned_capacity_gb", value);
    }

    /// <summary>
    /// Provisioned IOPS of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39;.
    /// </summary>
    public TerraformProperty<string> PoolProvisionedIops
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pool_provisioned_iops");
        set => SetProperty("pool_provisioned_iops", value);
    }

    /// <summary>
    /// Provisioned throughput, in MB/s, of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39; or &#39;hyperdisk-throughput&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolProvisionedThroughput is required")]
    public required TerraformProperty<string> PoolProvisionedThroughput
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pool_provisioned_throughput");
        set => SetProperty("pool_provisioned_throughput", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Type of the storage pool. For example, the
    /// following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/{project_id}/zones/{zone}/storagePoolTypes/hyperdisk-balanced&#39;
    /// * &#39;hyperdisk-throughput&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    public required TerraformProperty<string> StoragePoolType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_pool_type");
        set => SetProperty("storage_pool_type", value);
    }

    /// <summary>
    /// A reference to the zone where the storage pool resides.
    /// </summary>
    public TerraformProperty<string> Zone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone");
        set => SetProperty("zone", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeStoragePoolTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// Type of the resource.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.
    /// Used internally during updates.
    /// </summary>
    public TerraformExpression LabelFingerprint => this["label_fingerprint"];

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    public TerraformExpression ResourceStatus => this["resource_status"];

    /// <summary>
    /// Status information for the storage pool resource.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
