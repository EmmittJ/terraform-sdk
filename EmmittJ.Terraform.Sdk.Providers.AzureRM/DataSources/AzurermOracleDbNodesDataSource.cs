using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_oracle_db_nodes.
/// </summary>
public class AzurermOracleDbNodesDataSource : TerraformDataSource
{
    public AzurermOracleDbNodesDataSource(string name) : base("azurerm_oracle_db_nodes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_nodes");
    }

    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    public string? CloudVmClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_vm_cluster_id")?.Value;
        set => this.WithProperty("cloud_vm_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The db_nodes attribute.
    /// </summary>
    public TerraformExpression DbNodes => this["db_nodes"];

}
