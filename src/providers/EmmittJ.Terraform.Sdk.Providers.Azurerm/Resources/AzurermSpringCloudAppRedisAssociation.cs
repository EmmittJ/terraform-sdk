using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudAppRedisAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppRedisAssociationTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_app_redis_association Terraform resource.
/// Manages a azurerm_spring_cloud_app_redis_association resource.
/// </summary>
public partial class AzurermSpringCloudAppRedisAssociation(string name) : TerraformResource("azurerm_spring_cloud_app_redis_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The redis_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedisAccessKey is required")]
    public required TerraformValue<string> RedisAccessKey
    {
        get => GetArgument<TerraformValue<string>>("redis_access_key");
        set => SetArgument("redis_access_key", value);
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedisCacheId is required")]
    public required TerraformValue<string> RedisCacheId
    {
        get => GetArgument<TerraformValue<string>>("redis_cache_id");
        set => SetArgument("redis_cache_id", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformValue<string> SpringCloudAppId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The ssl_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SslEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ssl_enabled");
        set => SetArgument("ssl_enabled", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudAppRedisAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudAppRedisAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
