using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_kusto_database.
/// </summary>
public class AzurermDataShareDatasetKustoDatabaseDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetKustoDatabaseDataSource(string name) : base("azurerm_data_share_dataset_kusto_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
        this.DeclareOutput("kusto_cluster_location");
        this.DeclareOutput("kusto_database_id");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    public string? ShareId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("share_id")?.Value;
        set => this.WithProperty("share_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    public TerraformExpression KustoClusterLocation => this["kusto_cluster_location"];

    /// <summary>
    /// The kusto_database_id attribute.
    /// </summary>
    public TerraformExpression KustoDatabaseId => this["kusto_database_id"];

}
