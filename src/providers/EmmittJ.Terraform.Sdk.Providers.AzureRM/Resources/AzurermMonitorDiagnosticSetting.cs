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
        set => SetProperty("category", value);
    }

    /// <summary>
    /// The category_group attribute.
    /// </summary>
    public TerraformProperty<string>? CategoryGroup
    {
        set => SetProperty("category_group", value);
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
        set => SetProperty("category", value);
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
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        set => SetProperty("category", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("eventhub_authorization_rule_id");
        SetOutput("eventhub_name");
        SetOutput("id");
        SetOutput("log_analytics_destination_type");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("partner_solution_id");
        SetOutput("storage_account_id");
        SetOutput("target_resource_id");
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    public TerraformProperty<string> EventhubAuthorizationRuleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_authorization_rule_id");
        set => SetProperty("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformProperty<string> EventhubName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_name");
        set => SetProperty("eventhub_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_destination_type attribute.
    /// </summary>
    public TerraformProperty<string> LogAnalyticsDestinationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_destination_type");
        set => SetProperty("log_analytics_destination_type", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The partner_solution_id attribute.
    /// </summary>
    public TerraformProperty<string> PartnerSolutionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partner_solution_id");
        set => SetProperty("partner_solution_id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_resource_id");
        set => SetProperty("target_resource_id", value);
    }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDiagnosticSettingEnabledLogBlock>? EnabledLog
    {
        set => SetProperty("enabled_log", value);
    }

    /// <summary>
    /// Block for enabled_metric.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorDiagnosticSettingEnabledMetricBlock>? EnabledMetric
    {
        set => SetProperty("enabled_metric", value);
    }

    /// <summary>
    /// Block for metric.
    /// Nesting mode: set
    /// </summary>
    [Obsolete("This block is deprecated.")]
    public HashSet<AzurermMonitorDiagnosticSettingMetricBlock>? Metric
    {
        set => SetProperty("metric", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorDiagnosticSettingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
