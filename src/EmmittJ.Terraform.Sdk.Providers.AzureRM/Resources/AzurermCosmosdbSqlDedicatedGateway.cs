using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_sql_dedicated_gateway resource.
/// </summary>
public class AzurermCosmosdbSqlDedicatedGateway : TerraformResource
{
    public AzurermCosmosdbSqlDedicatedGateway(string name) : base("azurerm_cosmosdb_sql_dedicated_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cosmosdb_account_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CosmosdbAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_account_id");
        set => this.WithProperty("cosmosdb_account_id", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_size");
        set => this.WithProperty("instance_size", value);
    }

}
