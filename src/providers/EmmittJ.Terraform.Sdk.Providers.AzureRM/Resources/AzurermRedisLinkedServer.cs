using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisLinkedServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Manages a azurerm_redis_linked_server resource.
/// </summary>
public class AzurermRedisLinkedServer : TerraformResource
{
    public AzurermRedisLinkedServer(string name) : base("azurerm_redis_linked_server", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The linked_redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheId is required")]
    [TerraformArgument("linked_redis_cache_id")]
    public required TerraformValue<string> LinkedRedisCacheId
    {
        get => new TerraformReference<string>(this, "linked_redis_cache_id");
        set => SetArgument("linked_redis_cache_id", value);
    }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheLocation is required")]
    [TerraformArgument("linked_redis_cache_location")]
    public required TerraformValue<string> LinkedRedisCacheLocation
    {
        get => new TerraformReference<string>(this, "linked_redis_cache_location");
        set => SetArgument("linked_redis_cache_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The server_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerRole is required")]
    [TerraformArgument("server_role")]
    public required TerraformValue<string> ServerRole
    {
        get => new TerraformReference<string>(this, "server_role");
        set => SetArgument("server_role", value);
    }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRedisCacheName is required")]
    [TerraformArgument("target_redis_cache_name")]
    public required TerraformValue<string> TargetRedisCacheName
    {
        get => new TerraformReference<string>(this, "target_redis_cache_name");
        set => SetArgument("target_redis_cache_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRedisLinkedServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The geo_replicated_primary_host_name attribute.
    /// </summary>
    [TerraformArgument("geo_replicated_primary_host_name")]
    public TerraformValue<string> GeoReplicatedPrimaryHostName
    {
        get => new TerraformReference<string>(this, "geo_replicated_primary_host_name");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

}
