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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("geo_replicated_primary_host_name");
        SetOutput("name");
        SetOutput("id");
        SetOutput("linked_redis_cache_id");
        SetOutput("linked_redis_cache_location");
        SetOutput("resource_group_name");
        SetOutput("server_role");
        SetOutput("target_redis_cache_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The linked_redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheId is required")]
    public required TerraformProperty<string> LinkedRedisCacheId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("linked_redis_cache_id");
        set => SetProperty("linked_redis_cache_id", value);
    }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheLocation is required")]
    public required TerraformProperty<string> LinkedRedisCacheLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("linked_redis_cache_location");
        set => SetProperty("linked_redis_cache_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerRole is required")]
    public required TerraformProperty<string> ServerRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_role");
        set => SetProperty("server_role", value);
    }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRedisCacheName is required")]
    public required TerraformProperty<string> TargetRedisCacheName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_redis_cache_name");
        set => SetProperty("target_redis_cache_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRedisLinkedServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
