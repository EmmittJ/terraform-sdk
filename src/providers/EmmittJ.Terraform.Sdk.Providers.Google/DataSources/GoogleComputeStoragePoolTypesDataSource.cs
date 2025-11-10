using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_storage_pool_types.
/// </summary>
public class GoogleComputeStoragePoolTypesDataSource : TerraformDataSource
{
    public GoogleComputeStoragePoolTypesDataSource(string name) : base("google_compute_storage_pool_types", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_timestamp");
        this.WithOutput("deprecated");
        this.WithOutput("description");
        this.WithOutput("id");
        this.WithOutput("kind");
        this.WithOutput("max_pool_provisioned_capacity_gb");
        this.WithOutput("max_pool_provisioned_iops");
        this.WithOutput("max_pool_provisioned_throughput");
        this.WithOutput("min_pool_provisioned_capacity_gb");
        this.WithOutput("min_pool_provisioned_iops");
        this.WithOutput("min_pool_provisioned_throughput");
        this.WithOutput("name");
        this.WithOutput("self_link");
        this.WithOutput("self_link_with_id");
        this.WithOutput("supported_disk_types");
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StoragePoolType is required")]
    public required TerraformProperty<string> StoragePoolType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_pool_type");
        set => this.WithProperty("storage_pool_type", value);
    }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zone is required")]
    public required TerraformProperty<string> Zone
    {
        get => GetRequiredProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The deprecation status associated with this storage pool type.
    /// </summary>
    public TerraformExpression Deprecated => this["deprecated"];

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The unique identifier for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// Type of the resource. Always compute#storagePoolType for storage pool types.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// Maximum storage pool size in GB.
    /// </summary>
    public TerraformExpression MaxPoolProvisionedCapacityGb => this["max_pool_provisioned_capacity_gb"];

    /// <summary>
    /// Maximum provisioned IOPS.
    /// </summary>
    public TerraformExpression MaxPoolProvisionedIops => this["max_pool_provisioned_iops"];

    /// <summary>
    /// Maximum provisioned throughput.
    /// </summary>
    public TerraformExpression MaxPoolProvisionedThroughput => this["max_pool_provisioned_throughput"];

    /// <summary>
    /// Minimum storage pool size in GB.
    /// </summary>
    public TerraformExpression MinPoolProvisionedCapacityGb => this["min_pool_provisioned_capacity_gb"];

    /// <summary>
    /// Minimum provisioned IOPS.
    /// </summary>
    public TerraformExpression MinPoolProvisionedIops => this["min_pool_provisioned_iops"];

    /// <summary>
    /// Minimum provisioned throughput.
    /// </summary>
    public TerraformExpression MinPoolProvisionedThroughput => this["min_pool_provisioned_throughput"];

    /// <summary>
    /// Name of the resource.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Server-defined URL for the resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Server-defined URL for this resource with the resource id.
    /// </summary>
    public TerraformExpression SelfLinkWithId => this["self_link_with_id"];

    /// <summary>
    /// The list of disk types supported in this storage pool type.
    /// </summary>
    public TerraformExpression SupportedDiskTypes => this["supported_disk_types"];

}
