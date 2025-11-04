using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kusto_cosmosdb_data_connection resource.
/// </summary>
public class AzurermKustoCosmosdbDataConnection : TerraformResource
{
    public AzurermKustoCosmosdbDataConnection(string name) : base("azurerm_kusto_cosmosdb_data_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cosmosdb_container_id attribute.
    /// </summary>
    public string? CosmosdbContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_container_id")?.Value;
        set => this.WithProperty("cosmosdb_container_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kusto_database_id attribute.
    /// </summary>
    public string? KustoDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_database_id")?.Value;
        set => this.WithProperty("kusto_database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The managed_identity_id attribute.
    /// </summary>
    public string? ManagedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_identity_id")?.Value;
        set => this.WithProperty("managed_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public string? MappingRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mapping_rule_name")?.Value;
        set => this.WithProperty("mapping_rule_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The retrieval_start_date attribute.
    /// </summary>
    public string? RetrievalStartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retrieval_start_date")?.Value;
        set => this.WithProperty("retrieval_start_date", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public string? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name")?.Value;
        set => this.WithProperty("table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
