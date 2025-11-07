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
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("deprecated");
        this.DeclareOutput("description");
        this.DeclareOutput("id");
        this.DeclareOutput("kind");
        this.DeclareOutput("max_pool_provisioned_capacity_gb");
        this.DeclareOutput("max_pool_provisioned_iops");
        this.DeclareOutput("max_pool_provisioned_throughput");
        this.DeclareOutput("min_pool_provisioned_capacity_gb");
        this.DeclareOutput("min_pool_provisioned_iops");
        this.DeclareOutput("min_pool_provisioned_throughput");
        this.DeclareOutput("name");
        this.DeclareOutput("self_link");
        this.DeclareOutput("self_link_with_id");
        this.DeclareOutput("supported_disk_types");
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Name of the storage pool type.
    /// </summary>
    public TerraformLiteralProperty<string>? StoragePoolType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_pool_type");
        set => this.WithProperty("storage_pool_type", value);
    }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    public TerraformLiteralProperty<string>? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone");
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
