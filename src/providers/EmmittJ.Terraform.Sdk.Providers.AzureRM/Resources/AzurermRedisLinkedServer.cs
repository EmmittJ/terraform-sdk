using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisLinkedServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutputeo_replicated_primary_host_name");
        this.WithOutputame");
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
    /// The linked_redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheId is required")]
    public required TerraformProperty<string> LinkedRedisCacheId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("linked_redis_cache_id");
        set => this.WithProperty("linked_redis_cache_id", value);
    }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheLocation is required")]
    public required TerraformProperty<string> LinkedRedisCacheLocation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("linked_redis_cache_location");
        set => this.WithProperty("linked_redis_cache_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerRole is required")]
    public required TerraformProperty<string> ServerRole
    {
        get => GetRequiredProperty<TerraformProperty<string>>("server_role");
        set => this.WithProperty("server_role", value);
    }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRedisCacheName is required")]
    public required TerraformProperty<string> TargetRedisCacheName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_redis_cache_name");
        set => this.WithProperty("target_redis_cache_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedisLinkedServerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRedisLinkedServerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
