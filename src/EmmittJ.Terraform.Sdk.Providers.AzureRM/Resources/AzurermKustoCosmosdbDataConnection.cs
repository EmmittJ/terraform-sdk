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
    public TerraformLiteralProperty<string>? CosmosdbContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_container_id");
        set => this.WithProperty("cosmosdb_container_id", value);
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
    /// The kusto_database_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KustoDatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kusto_database_id");
        set => this.WithProperty("kusto_database_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ManagedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_identity_id");
        set => this.WithProperty("managed_identity_id", value);
    }

    /// <summary>
    /// The mapping_rule_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MappingRuleName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mapping_rule_name");
        set => this.WithProperty("mapping_rule_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The retrieval_start_date attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RetrievalStartDate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retrieval_start_date");
        set => this.WithProperty("retrieval_start_date", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_name");
        set => this.WithProperty("table_name", value);
    }

}
