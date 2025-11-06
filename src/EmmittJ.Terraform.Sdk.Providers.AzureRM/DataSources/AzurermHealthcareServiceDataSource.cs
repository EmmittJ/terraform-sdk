using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_healthcare_service.
/// </summary>
public class AzurermHealthcareServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareServiceDataSource(string name) : base("azurerm_healthcare_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_object_ids");
        this.DeclareOutput("authentication_configuration");
        this.DeclareOutput("cors_configuration");
        this.DeclareOutput("cosmosdb_key_vault_key_versionless_id");
        this.DeclareOutput("cosmosdb_throughput");
        this.DeclareOutput("kind");
        this.DeclareOutput("tags");
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public TerraformExpression AccessPolicyObjectIds => this["access_policy_object_ids"];

    /// <summary>
    /// The authentication_configuration attribute.
    /// </summary>
    public TerraformExpression AuthenticationConfiguration => this["authentication_configuration"];

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformExpression CorsConfiguration => this["cors_configuration"];

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    public TerraformExpression CosmosdbKeyVaultKeyVersionlessId => this["cosmosdb_key_vault_key_versionless_id"];

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    public TerraformExpression CosmosdbThroughput => this["cosmosdb_throughput"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
