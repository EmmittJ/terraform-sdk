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
    public string? CosmosMongoDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmos_mongo_database_id")?.Value;
        set => this.WithProperty("cosmos_mongo_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inherited_role_names attribute.
    /// </summary>
    public List<string>? InheritedRoleNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("inherited_role_names")?.Value;
        set => this.WithProperty("inherited_role_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public string? RoleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_name")?.Value;
        set => this.WithProperty("role_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
