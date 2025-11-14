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
/// Block type for enabled_log in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enabled_log";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [TerraformArgument("category")]
    public TerraformValue<string>? Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    [TerraformArgument("category_group")]
    public TerraformValue<string>? CategoryGroup
    {
        get => new TerraformReference<string>(this, "category_group");
        set => SetArgument("category_group", value);
    }

}

/// <summary>
/// Block type for enabled_metric in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enabled_metric";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformArgument("category")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: set
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMonitorDiagnosticSettingMetricBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformArgument("category")]
    public required TerraformValue<string> Category
    {
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticSettingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_monitor_diagnostic_setting resource.
/// </summary>
public class AzurermMonitorDiagnosticSetting : TerraformResource
{
    public AzurermMonitorDiagnosticSetting(string name) : base("azurerm_monitor_diagnostic_setting", name)
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    [TerraformArgument("eventhub_authorization_rule_id")]
    public TerraformValue<string>? EventhubAuthorizationRuleId
    {
        get => new TerraformReference<string>(this, "eventhub_authorization_rule_id");
        set => SetArgument("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformArgument("eventhub_name")]
    public TerraformValue<string>? EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
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
    /// The log_analytics_destination_type attribute.
    /// </summary>
    [TerraformArgument("log_analytics_destination_type")]
    public TerraformValue<string> LogAnalyticsDestinationType
    {
        get => new TerraformReference<string>(this, "log_analytics_destination_type");
        set => SetArgument("log_analytics_destination_type", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformArgument("log_analytics_workspace_id")]
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
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
    /// The partner_solution_id attribute.
    /// </summary>
    [TerraformArgument("partner_solution_id")]
    public TerraformValue<string>? PartnerSolutionId
    {
        get => new TerraformReference<string>(this, "partner_solution_id");
        set => SetArgument("partner_solution_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformArgument("target_resource_id")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("enabled_log")]
    public TerraformSet<AzurermMonitorDiagnosticSettingEnabledLogBlock> EnabledLog { get; set; } = new();

    /// <summary>
    /// Block for enabled_metric.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("enabled_metric")]
    public TerraformSet<AzurermMonitorDiagnosticSettingEnabledMetricBlock> EnabledMetric { get; set; } = new();

    /// <summary>
    /// Block for metric.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformArgument("metric")]
    public TerraformSet<AzurermMonitorDiagnosticSettingMetricBlock> Metric { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorDiagnosticSettingTimeoutsBlock Timeouts { get; set; } = new();

}
