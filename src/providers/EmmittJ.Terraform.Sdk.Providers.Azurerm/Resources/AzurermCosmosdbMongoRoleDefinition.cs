using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for privilege in AzurermCosmosdbMongoRoleDefinition.
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
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// Resource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Resource block(s) allowed")]
    public required TerraformList<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlockResourceBlock> Resource
    {
        get => GetRequiredArgument<TerraformList<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlockResourceBlock>>("resource");
        set => SetArgument("resource", value);
    }

}

/// <summary>
/// Block type for resource in AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbMongoRoleDefinitionPrivilegeBlockResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource";

    /// <summary>
    /// The collection_name attribute.
    /// </summary>
    public TerraformValue<string>? CollectionName
    {
        get => GetArgument<TerraformValue<string>>("collection_name");
        set => SetArgument("collection_name", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string>? DbName
    {
        get => GetArgument<TerraformValue<string>>("db_name");
        set => SetArgument("db_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCosmosdbMongoRoleDefinition.
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
        get => GetRequiredArgument<TerraformValue<string>>("cosmos_mongo_database_id");
        set => SetArgument("cosmos_mongo_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inherited_role_names attribute.
    /// </summary>
    public TerraformList<string>? InheritedRoleNames
    {
        get => GetArgument<TerraformList<string>>("inherited_role_names");
        set => SetArgument("inherited_role_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformValue<string> RoleName
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// Privilege block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock>? Privilege
    {
        get => GetArgument<TerraformList<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock>>("privilege");
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
