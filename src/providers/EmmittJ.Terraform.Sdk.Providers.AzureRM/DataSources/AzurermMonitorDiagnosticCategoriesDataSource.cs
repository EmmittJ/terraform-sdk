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
public class AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_monitor_diagnostic_categories.
/// </summary>
public class AzurermMonitorDiagnosticCategoriesDataSource : TerraformDataSource
{
    public AzurermMonitorDiagnosticCategoriesDataSource(string name) : base("azurerm_monitor_diagnostic_categories", name)
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
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    [TerraformArgument("resource_id")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorDiagnosticCategoriesDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The log_category_groups attribute.
    /// </summary>
    [TerraformArgument("log_category_groups")]
    public TerraformSet<string> LogCategoryGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_category_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The log_category_types attribute.
    /// </summary>
    [TerraformArgument("log_category_types")]
    public TerraformSet<string> LogCategoryTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_category_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The metrics attribute.
    /// </summary>
    [TerraformArgument("metrics")]
    public TerraformSet<string> Metrics
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "metrics").ResolveNodes(ctx));
    }

}
