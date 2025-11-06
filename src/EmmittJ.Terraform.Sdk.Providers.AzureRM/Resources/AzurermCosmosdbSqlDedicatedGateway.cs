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
    public string? CosmosdbAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cosmosdb_account_id")?.Value;
        set => this.WithProperty("cosmosdb_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_count attribute.
    /// </summary>
    public double? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count")?.Value;
        set => this.WithProperty("instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The instance_size attribute.
    /// </summary>
    public string? InstanceSize
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_size")?.Value;
        set => this.WithProperty("instance_size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
