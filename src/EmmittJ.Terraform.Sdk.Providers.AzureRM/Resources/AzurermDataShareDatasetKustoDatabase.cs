using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_data_share_dataset_kusto_database resource.
/// </summary>
public class AzurermDataShareDatasetKustoDatabase : TerraformResource
{
    public AzurermDataShareDatasetKustoDatabase(string name) : base("azurerm_data_share_dataset_kusto_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("display_name");
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
    /// The kusto_database_id attribute.
    /// </summary>
    public TerraformProperty<string>? KustoDatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("kusto_database_id");
        set => this.WithProperty("kusto_database_id", value);
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
    /// The kusto_cluster_location attribute.
    /// </summary>
    public TerraformExpression KustoClusterLocation => this["kusto_cluster_location"];

}
