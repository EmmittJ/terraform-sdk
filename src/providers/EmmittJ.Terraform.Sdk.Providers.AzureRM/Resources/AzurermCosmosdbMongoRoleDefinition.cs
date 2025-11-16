using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
/// Represents a azurerm_cosmosdb_mongo_role_definition Terraform resource.
/// Manages a azurerm_cosmosdb_mongo_role_definition resource.
/// </summary>
public partial class AzurermCosmosdbMongoRoleDefinition(string name) : TerraformResource("azurerm_cosmosdb_mongo_role_definition", name)
{
    /// <summary>
    /// The cosmos_mongo_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosMongoDatabaseId is required")]
    public required TerraformValue<string> CosmosMongoDatabaseId
    {
        get => new TerraformReference<string>(this, "cosmos_mongo_database_id");
        set => SetArgument("cosmos_mongo_database_id", value);
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
    /// The inherited_role_names attribute.
    /// </summary>
    public TerraformList<string>? InheritedRoleNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "inherited_role_names").ResolveNodes(ctx));
        set => SetArgument("inherited_role_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => new TerraformReference<string>(this, "role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// Privilege block (nesting mode: list).
    /// </summary>
    public AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock? Privilege
    {
        get => GetArgument<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock>("privilege");
        set => SetArgument("privilege", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
