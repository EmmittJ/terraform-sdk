using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_redis_enterprise_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermRedisEnterpriseDatabase : TerraformResource
{
    public AzurermRedisEnterpriseDatabase(string name) : base("azurerm_redis_enterprise_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_protocol");
        set => this.WithProperty("client_protocol", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusteringPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("clustering_policy");
        set => this.WithProperty("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LinkedDatabaseGroupNickname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_database_group_nickname");
        set => this.WithProperty("linked_database_group_nickname", value);
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LinkedDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("linked_database_id");
        set => this.WithProperty("linked_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}
