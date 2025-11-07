using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? CosmosMongoDatabaseId
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
    public TerraformProperty<List<string>>? InheritedRoleNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("inherited_role_names");
        set => this.WithProperty("inherited_role_names", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => this.WithProperty("role_name", value);
    }

}
