using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMonitorDiagnosticCategoriesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_diagnostic_categories Terraform data source.
/// Retrieves information about a azurerm_monitor_diagnostic_categories.
/// </summary>
public partial class AzurermMonitorDiagnosticCategoriesDataSource(string name) : TerraformDataSource("azurerm_monitor_diagnostic_categories", name)
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    public TerraformSet<string> LogCategoryGroups
        => AsReference("log_category_groups");

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    public TerraformSet<string> LogCategoryTypes
        => AsReference("log_category_types");

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    public TerraformSet<string> Metrics
        => AsReference("metrics");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
