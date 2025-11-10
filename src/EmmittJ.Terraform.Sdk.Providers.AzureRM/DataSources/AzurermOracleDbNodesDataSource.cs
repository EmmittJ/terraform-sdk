using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbNodesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformProperty<string> CloudVmClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_vm_cluster_id");
        set => this.WithProperty("cloud_vm_cluster_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleDbNodesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleDbNodesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The db_nodes attribute.
    /// </summary>
    public TerraformExpression DbNodes => this["db_nodes"];

}
