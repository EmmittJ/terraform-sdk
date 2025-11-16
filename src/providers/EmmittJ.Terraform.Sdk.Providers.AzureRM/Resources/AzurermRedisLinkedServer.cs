using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_redis_linked_server Terraform resource.
/// Manages a azurerm_redis_linked_server resource.
/// </summary>
public partial class AzurermRedisLinkedServer(string name) : TerraformResource("azurerm_redis_linked_server", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The linked_redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheId is required")]
    public required TerraformValue<string> LinkedRedisCacheId
    {
        get => new TerraformReference<string>(this, "linked_redis_cache_id");
        set => SetArgument("linked_redis_cache_id", value);
    }

    /// <summary>
    /// The linked_redis_cache_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedRedisCacheLocation is required")]
    public required TerraformValue<string> LinkedRedisCacheLocation
    {
        get => new TerraformReference<string>(this, "linked_redis_cache_location");
        set => SetArgument("linked_redis_cache_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The server_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerRole is required")]
    public required TerraformValue<string> ServerRole
    {
        get => new TerraformReference<string>(this, "server_role");
        set => SetArgument("server_role", value);
    }

    /// <summary>
    /// The target_redis_cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRedisCacheName is required")]
    public required TerraformValue<string> TargetRedisCacheName
    {
        get => new TerraformReference<string>(this, "target_redis_cache_name");
        set => SetArgument("target_redis_cache_name", value);
    }

    /// <summary>
    /// The geo_replicated_primary_host_name attribute.
    /// </summary>
    public TerraformValue<string> GeoReplicatedPrimaryHostName
    {
        get => new TerraformReference<string>(this, "geo_replicated_primary_host_name");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisLinkedServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisLinkedServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
