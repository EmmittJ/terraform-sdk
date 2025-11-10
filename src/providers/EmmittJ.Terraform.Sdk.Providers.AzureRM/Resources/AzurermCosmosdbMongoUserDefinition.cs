using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCosmosdbMongoUserDefinitionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cosmosdb_mongo_user_definition resource.
/// </summary>
public class AzurermCosmosdbMongoUserDefinition : TerraformResource
{
    public AzurermCosmosdbMongoUserDefinition(string name) : base("azurerm_cosmosdb_mongo_user_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cosmos_mongo_database_id");
        SetOutput("id");
        SetOutput("inherited_role_names");
        SetOutput("password");
        SetOutput("username");
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
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCosmosdbMongoUserDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
