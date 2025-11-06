using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_search_service.
/// </summary>
public class AzurermSearchServiceDataSource : TerraformDataSource
{
    public AzurermSearchServiceDataSource(string name) : base("azurerm_search_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("customer_managed_key_encryption_compliance_status");
        this.DeclareOutput("identity");
        this.DeclareOutput("partition_count");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("public_network_access_enabled");
        this.DeclareOutput("query_keys");
        this.DeclareOutput("replica_count");
        this.DeclareOutput("secondary_key");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_managed_key_encryption_compliance_status attribute.
    /// </summary>
    public TerraformExpression CustomerManagedKeyEncryptionComplianceStatus => this["customer_managed_key_encryption_compliance_status"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The partition_count attribute.
    /// </summary>
    public TerraformExpression PartitionCount => this["partition_count"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

    /// <summary>
    /// The query_keys attribute.
    /// </summary>
    public TerraformExpression QueryKeys => this["query_keys"];

    /// <summary>
    /// The replica_count attribute.
    /// </summary>
    public TerraformExpression ReplicaCount => this["replica_count"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
