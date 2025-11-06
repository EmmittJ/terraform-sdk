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
    public string? ClientProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_protocol")?.Value;
        set => this.WithProperty("client_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public string? ClusteringPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("clustering_policy")?.Value;
        set => this.WithProperty("clustering_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public string? EvictionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eviction_policy")?.Value;
        set => this.WithProperty("eviction_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The linked_database_group_nickname attribute.
    /// </summary>
    public string? LinkedDatabaseGroupNickname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_database_group_nickname")?.Value;
        set => this.WithProperty("linked_database_group_nickname", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    public HashSet<string>? LinkedDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("linked_database_id")?.Value;
        set => this.WithProperty("linked_database_id", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The port attribute.
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
