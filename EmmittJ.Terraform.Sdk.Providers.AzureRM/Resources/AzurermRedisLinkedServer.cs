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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linked_redis_cache_id attribute.
    /// </summary>
    public string? LinkedRedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_redis_cache_id")?.Value;
        set => this.WithProperty("linked_redis_cache_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    public string? LinkedRedisCacheLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_redis_cache_location")?.Value;
        set => this.WithProperty("linked_redis_cache_location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The server_role attribute.
    /// </summary>
    public string? ServerRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_role")?.Value;
        set => this.WithProperty("server_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    public string? TargetRedisCacheName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_redis_cache_name")?.Value;
        set => this.WithProperty("target_redis_cache_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
