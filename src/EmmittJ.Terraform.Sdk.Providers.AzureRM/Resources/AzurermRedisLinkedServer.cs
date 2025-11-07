using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_redis_linked_server resource.
/// </summary>
public class AzurermRedisLinkedServer : TerraformResource
{
    public AzurermRedisLinkedServer(string name) : base("azurerm_redis_linked_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("geo_replicated_primary_host_name");
        this.DeclareOutput("name");
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
    /// The linked_redis_cache_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LinkedRedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_redis_cache_id");
        set => this.WithProperty("linked_redis_cache_id", value);
    }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LinkedRedisCacheLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_redis_cache_location");
        set => this.WithProperty("linked_redis_cache_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_role attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_role");
        set => this.WithProperty("server_role", value);
    }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetRedisCacheName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_redis_cache_name");
        set => this.WithProperty("target_redis_cache_name", value);
    }

    /// <summary>
    /// The geo_replicated_primary_host_name attribute.
    /// </summary>
    public TerraformExpression GeoReplicatedPrimaryHostName => this["geo_replicated_primary_host_name"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
