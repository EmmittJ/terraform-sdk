using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_log_analytics_workspace_table.
/// </summary>
public class AzurermLogAnalyticsWorkspaceTableDataSource : TerraformDataSource
{
    public AzurermLogAnalyticsWorkspaceTableDataSource(string name) : base("azurerm_log_analytics_workspace_table", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformArgument("workspace_id")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLogAnalyticsWorkspaceTableDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformArgument("plan")]
    public TerraformValue<string> Plan
    {
        get => new TerraformReference<string>(this, "plan");
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformArgument("retention_in_days")]
    public TerraformValue<double> RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
    }

    /// <summary>
    /// The total_retention_in_days attribute.
    /// </summary>
    [TerraformArgument("total_retention_in_days")]
    public TerraformValue<double> TotalRetentionInDays
    {
        get => new TerraformReference<double>(this, "total_retention_in_days");
    }

}
