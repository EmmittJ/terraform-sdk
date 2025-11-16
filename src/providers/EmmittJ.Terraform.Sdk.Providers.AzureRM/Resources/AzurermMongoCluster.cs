using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMongoClusterTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_mongo_cluster Terraform resource.
/// Manages a azurerm_mongo_cluster resource.
/// </summary>
public partial class AzurermMongoCluster(string name) : TerraformResource("azurerm_mongo_cluster", name)
{
    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorPassword
    {
        get => new TerraformReference<string>(this, "administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorUsername
    {
        get => new TerraformReference<string>(this, "administrator_username");
        set => SetArgument("administrator_username", value);
    }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    public TerraformValue<string>? ComputeTier
    {
        get => new TerraformReference<string>(this, "compute_tier");
        set => SetArgument("compute_tier", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    public TerraformValue<string>? HighAvailabilityMode
    {
        get => new TerraformReference<string>(this, "high_availability_mode");
        set => SetArgument("high_availability_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The preview_features attribute.
    /// </summary>
    public TerraformList<string>? PreviewFeatures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preview_features").ResolveNodes(ctx));
        set => SetArgument("preview_features", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
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
    /// The shard_count attribute.
    /// </summary>
    public TerraformValue<double>? ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    public TerraformValue<string>? SourceLocation
    {
        get => new TerraformReference<string>(this, "source_location");
        set => SetArgument("source_location", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    public TerraformValue<string>? SourceServerId
    {
        get => new TerraformReference<string>(this, "source_server_id");
        set => SetArgument("source_server_id", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? StorageSizeInGb
    {
        get => new TerraformReference<double>(this, "storage_size_in_gb");
        set => SetArgument("storage_size_in_gb", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ConnectionStrings
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "connection_strings").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMongoClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMongoClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
