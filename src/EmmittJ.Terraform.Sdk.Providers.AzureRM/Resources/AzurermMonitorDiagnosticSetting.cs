using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for enabled_log in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledLogBlock : TerraformBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformProperty<string>? Category
    {
        get => GetProperty<TerraformProperty<string>>("category");
        set => WithProperty("category", value);
    }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    public TerraformProperty<string>? CategoryGroup
    {
        get => GetProperty<TerraformProperty<string>>("category_group");
        set => WithProperty("category_group", value);
    }

}

/// <summary>
/// Block type for enabled_metric in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingEnabledMetricBlock : TerraformBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetRequiredProperty<TerraformProperty<string>>("category");
        set => WithProperty("category", value);
    }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorDiagnosticSettingMetricBlock : TerraformBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetRequiredProperty<TerraformProperty<string>>("category");
        set => WithProperty("category", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorDiagnosticSettingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_monitor_diagnostic_setting resource.
/// </summary>
public class AzurermMonitorDiagnosticSetting : TerraformResource
{
    public AzurermMonitorDiagnosticSetting(string name) : base("azurerm_monitor_diagnostic_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubAuthorizationRuleId
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_authorization_rule_id");
        set => this.WithProperty("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_name");
        set => this.WithProperty("eventhub_name", value);
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
    /// The log_analytics_destination_type attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsDestinationType
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_destination_type");
        set => this.WithProperty("log_analytics_destination_type", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partner_solution_id attribute.
    /// </summary>
    public TerraformProperty<string>? PartnerSolutionId
    {
        get => GetProperty<TerraformProperty<string>>("partner_solution_id");
        set => this.WithProperty("partner_solution_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountId
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDiagnosticSettingEnabledLogBlock>? EnabledLog
    {
        get => GetProperty<HashSet<AzurermMonitorDiagnosticSettingEnabledLogBlock>>("enabled_log");
        set => this.WithProperty("enabled_log", value);
    }

    /// <summary>
    /// Block for enabled_metric.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDiagnosticSettingEnabledMetricBlock>? EnabledMetric
    {
        get => GetProperty<HashSet<AzurermMonitorDiagnosticSettingEnabledMetricBlock>>("enabled_metric");
        set => this.WithProperty("enabled_metric", value);
    }

    /// <summary>
    /// Block for metric.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDiagnosticSettingMetricBlock>? Metric
    {
        get => GetProperty<HashSet<AzurermMonitorDiagnosticSettingMetricBlock>>("metric");
        set => this.WithProperty("metric", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorDiagnosticSettingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorDiagnosticSettingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
