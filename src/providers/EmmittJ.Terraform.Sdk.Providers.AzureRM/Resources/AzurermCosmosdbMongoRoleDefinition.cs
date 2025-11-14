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
/// Block type for privilege in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "privilege";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformArgument("actions")]
    public TerraformList<string>? Actions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "actions").ResolveNodes(ctx));
        set => SetArgument("actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cosmosdb_mongo_role_definition resource.
/// </summary>
public class AzurermCosmosdbMongoRoleDefinition : TerraformResource
{
    public AzurermCosmosdbMongoRoleDefinition(string name) : base("azurerm_cosmosdb_mongo_role_definition", name)
    {
    }

    /// <summary>
    /// The cosmos_mongo_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosMongoDatabaseId is required")]
    [TerraformArgument("cosmos_mongo_database_id")]
    public required TerraformValue<string> CosmosMongoDatabaseId
    {
        get => new TerraformReference<string>(this, "cosmos_mongo_database_id");
        set => SetArgument("cosmos_mongo_database_id", value);
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
    /// The inherited_role_names attribute.
    /// </summary>
    [TerraformArgument("inherited_role_names")]
    public TerraformList<string>? InheritedRoleNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "inherited_role_names").ResolveNodes(ctx));
        set => SetArgument("inherited_role_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    [TerraformArgument("role_name")]
    public required TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// Block for privilege.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("privilege")]
    public TerraformList<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock> Privilege { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock Timeouts { get; set; } = new();

}
