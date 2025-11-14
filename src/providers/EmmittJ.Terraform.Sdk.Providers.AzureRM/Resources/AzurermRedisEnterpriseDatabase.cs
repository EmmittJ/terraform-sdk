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
/// Block type for module in .
/// Nesting mode: list
/// </summary>
public class AzurermRedisEnterpriseDatabaseModuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "module";

    /// <summary>
    /// The args attribute.
    /// </summary>
    [TerraformArgument("args")]
    public TerraformValue<string>? Args
    {
        get => new TerraformReference<string>(this, "args");
        set => SetArgument("args", value);
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


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRedisEnterpriseDatabaseTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_redis_enterprise_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermRedisEnterpriseDatabase : TerraformResource
{
    public AzurermRedisEnterpriseDatabase(string name) : base("azurerm_redis_enterprise_database", name)
    {
    }

    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    [TerraformArgument("client_protocol")]
    public TerraformValue<string>? ClientProtocol
    {
        get => new TerraformReference<string>(this, "client_protocol");
        set => SetArgument("client_protocol", value);
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformArgument("cluster_id")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The clustering_policy attribute.
    /// </summary>
    [TerraformArgument("clustering_policy")]
    public TerraformValue<string>? ClusteringPolicy
    {
        get => new TerraformReference<string>(this, "clustering_policy");
        set => SetArgument("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    [TerraformArgument("eviction_policy")]
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
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
    /// The linked_database_group_nickname attribute.
    /// </summary>
    [TerraformArgument("linked_database_group_nickname")]
    public TerraformValue<string>? LinkedDatabaseGroupNickname
    {
        get => new TerraformReference<string>(this, "linked_database_group_nickname");
        set => SetArgument("linked_database_group_nickname", value);
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    [TerraformArgument("linked_database_id")]
    public TerraformSet<string>? LinkedDatabaseId
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "linked_database_id").ResolveNodes(ctx));
        set => SetArgument("linked_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformArgument("port")]
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Block for module.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Module block(s) allowed")]
    [TerraformArgument("module")]
    public TerraformList<AzurermRedisEnterpriseDatabaseModuleBlock> Module { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRedisEnterpriseDatabaseTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformArgument("primary_access_key")]
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformArgument("secondary_access_key")]
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

}
