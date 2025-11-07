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
    public TerraformProperty<string>? ClientProtocol
    {
        get => GetProperty<TerraformProperty<string>>("client_protocol");
        set => this.WithProperty("client_protocol", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ClusteringPolicy
    {
        get => GetProperty<TerraformProperty<string>>("clustering_policy");
        set => this.WithProperty("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EvictionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("eviction_policy");
        set => this.WithProperty("eviction_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    public TerraformProperty<string>? LinkedDatabaseGroupNickname
    {
        get => GetProperty<TerraformProperty<string>>("linked_database_group_nickname");
        set => this.WithProperty("linked_database_group_nickname", value);
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? LinkedDatabaseId
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("linked_database_id");
        set => this.WithProperty("linked_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
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
