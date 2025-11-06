using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("id");
        this.DeclareOutput("kind");
        this.DeclareOutput("label_fingerprint");
        this.DeclareOutput("resource_status");
        this.DeclareOutput("status");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Provisioning type of the byte capacity of the pool. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    public string? CapacityProvisioningType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("capacity_provisioning_type")?.Value;
        set => this.WithProperty("capacity_provisioning_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the StoragePool.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the StoragePool will fail.
    /// When the field is set to false, deleting the StoragePool is allowed.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// A description of this resource. Provide this property when you create the resource.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Labels to apply to this storage pool. These can be later modified by the setLabels method.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Provisioning type of the performance-related parameters of the pool, such as throughput and IOPS. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ADVANCED&amp;quot;]
    /// </summary>
    public string? PerformanceProvisioningType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("performance_provisioning_type")?.Value;
        set => this.WithProperty("performance_provisioning_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Size, in GiB, of the storage pool. For more information about the size limits,
    /// see https://cloud.google.com/compute/docs/disks/storage-pools.
    /// </summary>
    public string? PoolProvisionedCapacityGb
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_provisioned_capacity_gb")?.Value;
        set => this.WithProperty("pool_provisioned_capacity_gb", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Provisioned IOPS of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39;.
    /// </summary>
    public string? PoolProvisionedIops
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_provisioned_iops")?.Value;
        set => this.WithProperty("pool_provisioned_iops", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Provisioned throughput, in MB/s, of the storage pool.
    /// Only relevant if the storage pool type is &#39;hyperdisk-balanced&#39; or &#39;hyperdisk-throughput&#39;.
    /// </summary>
    public string? PoolProvisionedThroughput
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pool_provisioned_throughput")?.Value;
        set => this.WithProperty("pool_provisioned_throughput", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Type of the storage pool. For example, the
    /// following are valid values:
    /// 
    /// * &#39;https://www.googleapis.com/compute/v1/projects/{project_id}/zones/{zone}/storagePoolTypes/hyperdisk-balanced&#39;
    /// * &#39;hyperdisk-throughput&#39;
    /// </summary>
    public string? StoragePoolType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_pool_type")?.Value;
        set => this.WithProperty("storage_pool_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A reference to the zone where the storage pool resides.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
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
