using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_data_share_dataset_kusto_cluster.
/// </summary>
public class AzurermDataShareDatasetKustoClusterDataSource : TerraformDataSource
{
    public AzurermDataShareDatasetKustoClusterDataSource(string name) : base("azurerm_data_share_dataset_kusto_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
        this.DeclareOutput("kusto_cluster_id");
        this.DeclareOutput("kusto_cluster_location");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    public TerraformProperty<string>? ShareId
    {
        get => GetProperty<TerraformProperty<string>>("share_id");
        set => this.WithProperty("share_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    public TerraformExpression KustoClusterId => this["kusto_cluster_id"];

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    public TerraformExpression KustoClusterLocation => this["kusto_cluster_location"];

}
