using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagedRedisGeoReplication.
/// Nesting mode: single
/// </summary>
public class AzurermManagedRedisGeoReplicationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_managed_redis_geo_replication Terraform resource.
/// Manages a azurerm_managed_redis_geo_replication resource.
/// </summary>
public partial class AzurermManagedRedisGeoReplication(string name) : TerraformResource("azurerm_managed_redis_geo_replication", name)
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
    /// The linked_managed_redis_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedManagedRedisIds is required")]
    public required TerraformSet<string> LinkedManagedRedisIds
    {
        get => GetArgument<TerraformSet<string>>("linked_managed_redis_ids");
        set => SetArgument("linked_managed_redis_ids", value);
    }

    /// <summary>
    /// The managed_redis_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedRedisId is required")]
    public required TerraformValue<string> ManagedRedisId
    {
        get => GetArgument<TerraformValue<string>>("managed_redis_id");
        set => SetArgument("managed_redis_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedRedisGeoReplicationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedRedisGeoReplicationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
