using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_postgresql_coordinator_configuration resource.
/// </summary>
public class AzurermCosmosdbPostgresqlCoordinatorConfiguration : TerraformResource
{
    public AzurermCosmosdbPostgresqlCoordinatorConfiguration(string name) : base("azurerm_cosmosdb_postgresql_coordinator_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Value
    {
        get => GetProperty<TerraformLiteralProperty<string>>("value");
        set => this.WithProperty("value", value);
    }

}
