using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsWorkspaceTableDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_log_analytics_workspace_table Terraform data source.
/// Retrieves information about a azurerm_log_analytics_workspace_table.
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTableDataSource(string name) : TerraformDataSource("azurerm_log_analytics_workspace_table", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformValue<string> Plan
        => AsReference("plan");

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double> RetentionInDays
        => AsReference("retention_in_days");

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    public TerraformValue<double> TotalRetentionInDays
        => AsReference("total_retention_in_days");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
