using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsWorkspaceTable.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_log_analytics_workspace_table Terraform resource.
/// Manages a azurerm_log_analytics_workspace_table resource.
/// </summary>
public partial class AzurermLogAnalyticsWorkspaceTable(string name) : TerraformResource("azurerm_log_analytics_workspace_table", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformValue<string>? Plan
    {
        get => new TerraformReference<string>(this, "plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? TotalRetentionInDays
    {
        get => new TerraformReference<double>(this, "total_retention_in_days");
        set => SetArgument("total_retention_in_days", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsWorkspaceTableTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsWorkspaceTableTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
