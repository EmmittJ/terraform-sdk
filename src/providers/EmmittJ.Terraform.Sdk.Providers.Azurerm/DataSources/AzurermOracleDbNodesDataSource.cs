using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleDbNodesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleDbNodesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_oracle_db_nodes Terraform data source.
/// Retrieves information about a azurerm_oracle_db_nodes.
/// </summary>
public partial class AzurermOracleDbNodesDataSource(string name) : TerraformDataSource("azurerm_oracle_db_nodes", name)
{
    /// <summary>
    /// The cloud_vm_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmClusterId is required")]
    public required TerraformValue<string> CloudVmClusterId
    {
        get => GetArgument<TerraformValue<string>>("cloud_vm_cluster_id");
        set => SetArgument("cloud_vm_cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The db_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbNodes
        => AsReference("db_nodes");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleDbNodesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleDbNodesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
