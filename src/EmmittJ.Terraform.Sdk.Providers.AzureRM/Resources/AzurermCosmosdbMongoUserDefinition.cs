using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The cosmos_mongo_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosMongoDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmos_mongo_database_id");
        set => this.WithProperty("cosmos_mongo_database_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The inherited_role_names attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? InheritedRoleNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("inherited_role_names");
        set => this.WithProperty("inherited_role_names", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

}
