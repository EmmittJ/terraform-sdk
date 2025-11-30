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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    public TerraformSet<string> LogCategoryGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_category_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    public TerraformSet<string> LogCategoryTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_category_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    public TerraformSet<string> Metrics
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "metrics").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
