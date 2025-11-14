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
public class AzurermMongoClusterTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mongo_cluster resource.
/// </summary>
public class AzurermMongoCluster : TerraformResource
{
    public AzurermMongoCluster(string name) : base("azurerm_mongo_cluster", name)
    {
    }

    /// <summary>
    /// The administrator_password attribute.
    /// </summary>
    [TerraformArgument("administrator_password")]
    public TerraformValue<string>? AdministratorPassword
    {
        get => new TerraformReference<string>(this, "administrator_password");
        set => SetArgument("administrator_password", value);
    }

    /// <summary>
    /// The administrator_username attribute.
    /// </summary>
    [TerraformArgument("administrator_username")]
    public TerraformValue<string>? AdministratorUsername
    {
        get => new TerraformReference<string>(this, "administrator_username");
        set => SetArgument("administrator_username", value);
    }

    /// <summary>
    /// The compute_tier attribute.
    /// </summary>
    [TerraformArgument("compute_tier")]
    public TerraformValue<string>? ComputeTier
    {
        get => new TerraformReference<string>(this, "compute_tier");
        set => SetArgument("compute_tier", value);
    }

    /// <summary>
    /// The create_mode attribute.
    /// </summary>
    [TerraformArgument("create_mode")]
    public TerraformValue<string>? CreateMode
    {
        get => new TerraformReference<string>(this, "create_mode");
        set => SetArgument("create_mode", value);
    }

    /// <summary>
    /// The high_availability_mode attribute.
    /// </summary>
    [TerraformArgument("high_availability_mode")]
    public TerraformValue<string>? HighAvailabilityMode
    {
        get => new TerraformReference<string>(this, "high_availability_mode");
        set => SetArgument("high_availability_mode", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The preview_features attribute.
    /// </summary>
    [TerraformArgument("preview_features")]
    public TerraformList<string>? PreviewFeatures
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "preview_features").ResolveNodes(ctx));
        set => SetArgument("preview_features", value);
    }

    /// <summary>
    /// The public_network_access attribute.
    /// </summary>
    [TerraformArgument("public_network_access")]
    public TerraformValue<string>? PublicNetworkAccess
    {
        get => new TerraformReference<string>(this, "public_network_access");
        set => SetArgument("public_network_access", value);
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
    /// The shard_count attribute.
    /// </summary>
    [TerraformArgument("shard_count")]
    public TerraformValue<double>? ShardCount
    {
        get => new TerraformReference<double>(this, "shard_count");
        set => SetArgument("shard_count", value);
    }

    /// <summary>
    /// The source_location attribute.
    /// </summary>
    [TerraformArgument("source_location")]
    public TerraformValue<string>? SourceLocation
    {
        get => new TerraformReference<string>(this, "source_location");
        set => SetArgument("source_location", value);
    }

    /// <summary>
    /// The source_server_id attribute.
    /// </summary>
    [TerraformArgument("source_server_id")]
    public TerraformValue<string>? SourceServerId
    {
        get => new TerraformReference<string>(this, "source_server_id");
        set => SetArgument("source_server_id", value);
    }

    /// <summary>
    /// The storage_size_in_gb attribute.
    /// </summary>
    [TerraformArgument("storage_size_in_gb")]
    public TerraformValue<double>? StorageSizeInGb
    {
        get => new TerraformReference<double>(this, "storage_size_in_gb");
        set => SetArgument("storage_size_in_gb", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMongoClusterTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The connection_strings attribute.
    /// </summary>
    [TerraformArgument("connection_strings")]
    public TerraformList<object> ConnectionStrings
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "connection_strings").ResolveNodes(ctx));
    }

}
