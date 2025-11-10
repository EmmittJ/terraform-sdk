using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for privilege in .
/// Nesting mode: list
/// </summary>
public class AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public List<TerraformProperty<string>>? Actions
    {
        set => SetProperty("actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cosmosdb_mongo_role_definition resource.
/// </summary>
public class AzurermCosmosdbMongoRoleDefinition : TerraformResource
{
    public AzurermCosmosdbMongoRoleDefinition(string name) : base("azurerm_cosmosdb_mongo_role_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cosmos_mongo_database_id");
        SetOutput("id");
        SetOutput("inherited_role_names");
        SetOutput("role_name");
    }

    /// <summary>
    /// The cosmos_mongo_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosMongoDatabaseId is required")]
    public required TerraformProperty<string> CosmosMongoDatabaseId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cosmos_mongo_database_id");
        set => SetProperty("cosmos_mongo_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The inherited_role_names attribute.
    /// </summary>
    public List<TerraformProperty<string>> InheritedRoleNames
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("inherited_role_names");
        set => SetProperty("inherited_role_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// Block for privilege.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock>? Privilege
    {
        set => SetProperty("privilege", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
