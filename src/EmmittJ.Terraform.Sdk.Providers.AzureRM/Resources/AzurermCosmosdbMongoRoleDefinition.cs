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
        get => GetProperty<List<TerraformProperty<string>>>("actions");
        set => WithProperty("actions", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The cosmos_mongo_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CosmosMongoDatabaseId is required")]
    public required TerraformProperty<string> CosmosMongoDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("cosmos_mongo_database_id");
        set => this.WithProperty("cosmos_mongo_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inherited_role_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? InheritedRoleNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("inherited_role_names");
        set => this.WithProperty("inherited_role_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleName is required")]
    public required TerraformProperty<string> RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

    /// <summary>
    /// Block for privilege.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock>? Privilege
    {
        get => GetProperty<List<AzurermCosmosdbMongoRoleDefinitionPrivilegeBlock>>("privilege");
        set => this.WithProperty("privilege", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermCosmosdbMongoRoleDefinitionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
