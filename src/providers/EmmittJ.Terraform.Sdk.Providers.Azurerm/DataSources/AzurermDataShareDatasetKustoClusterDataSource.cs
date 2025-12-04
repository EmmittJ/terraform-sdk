using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataShareDatasetKustoClusterDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_data_share_dataset_kusto_cluster Terraform data source.
/// Retrieves information about a azurerm_data_share_dataset_kusto_cluster.
/// </summary>
public partial class AzurermDataShareDatasetKustoClusterDataSource(string name) : TerraformDataSource("azurerm_data_share_dataset_kusto_cluster", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    public required TerraformValue<string> ShareId
    {
        get => GetArgument<TerraformValue<string>>("share_id");
        set => SetArgument("share_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The kusto_cluster_id attribute.
    /// </summary>
    public TerraformValue<string> KustoClusterId
        => AsReference("kusto_cluster_id");

    /// <summary>
    /// The kusto_cluster_location attribute.
    /// </summary>
    public TerraformValue<string> KustoClusterLocation
        => AsReference("kusto_cluster_location");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataShareDatasetKustoClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
