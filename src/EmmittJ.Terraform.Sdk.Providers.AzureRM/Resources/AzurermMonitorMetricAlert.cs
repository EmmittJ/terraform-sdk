using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorMetricAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    public required TerraformProperty<string> ActionGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("action_group_id");
        set => WithProperty("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? WebhookProperties
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("webhook_properties");
        set => WithProperty("webhook_properties", value);
    }

}

/// <summary>
/// Block type for application_insights_web_test_location_availability_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// The component_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentId is required")]
    public required TerraformProperty<string> ComponentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("component_id");
        set => WithProperty("component_id", value);
    }

    /// <summary>
    /// The failed_location_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailedLocationCount is required")]
    public required TerraformProperty<double> FailedLocationCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("failed_location_count");
        set => WithProperty("failed_location_count", value);
    }

    /// <summary>
    /// The web_test_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebTestId is required")]
    public required TerraformProperty<string> WebTestId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("web_test_id");
        set => WithProperty("web_test_id", value);
    }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    public required TerraformProperty<string> Aggregation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("aggregation");
        set => WithProperty("aggregation", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_name");
        set => WithProperty("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformProperty<string> MetricNamespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_namespace");
        set => WithProperty("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        get => GetRequiredProperty<TerraformProperty<string>>("operator");
        set => WithProperty("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipMetricValidation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_metric_validation");
        set => WithProperty("skip_metric_validation", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        get => GetRequiredProperty<TerraformProperty<double>>("threshold");
        set => WithProperty("threshold", value);
    }

}

/// <summary>
/// Block type for dynamic_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertDynamicCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    public required TerraformProperty<string> Aggregation
    {
        get => GetRequiredProperty<TerraformProperty<string>>("aggregation");
        set => WithProperty("aggregation", value);
    }

    /// <summary>
    /// The alert_sensitivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertSensitivity is required")]
    public required TerraformProperty<string> AlertSensitivity
    {
        get => GetRequiredProperty<TerraformProperty<string>>("alert_sensitivity");
        set => WithProperty("alert_sensitivity", value);
    }

    /// <summary>
    /// The evaluation_failure_count attribute.
    /// </summary>
    public TerraformProperty<double>? EvaluationFailureCount
    {
        get => GetProperty<TerraformProperty<double>>("evaluation_failure_count");
        set => WithProperty("evaluation_failure_count", value);
    }

    /// <summary>
    /// The evaluation_total_count attribute.
    /// </summary>
    public TerraformProperty<double>? EvaluationTotalCount
    {
        get => GetProperty<TerraformProperty<double>>("evaluation_total_count");
        set => WithProperty("evaluation_total_count", value);
    }

    /// <summary>
    /// The ignore_data_before attribute.
    /// </summary>
    public TerraformProperty<string>? IgnoreDataBefore
    {
        get => GetProperty<TerraformProperty<string>>("ignore_data_before");
        set => WithProperty("ignore_data_before", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_name");
        set => WithProperty("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformProperty<string> MetricNamespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_namespace");
        set => WithProperty("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        get => GetRequiredProperty<TerraformProperty<string>>("operator");
        set => WithProperty("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipMetricValidation
    {
        get => GetProperty<TerraformProperty<bool>>("skip_metric_validation");
        set => WithProperty("skip_metric_validation", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorMetricAlertTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_monitor_metric_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorMetricAlert : TerraformResource
{
    public AzurermMonitorMetricAlert(string name) : base("azurerm_monitor_metric_alert", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_mitigate attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMitigate
    {
        get => GetProperty<TerraformProperty<bool>>("auto_mitigate");
        set => this.WithProperty("auto_mitigate", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<string>? Frequency
    {
        get => GetProperty<TerraformProperty<string>>("frequency");
        set => this.WithProperty("frequency", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>>? Scopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("scopes");
        set => this.WithProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<double>? Severity
    {
        get => GetProperty<TerraformProperty<double>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformProperty<string>? TargetResourceLocation
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_location");
        set => this.WithProperty("target_resource_location", value);
    }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformProperty<string>? TargetResourceType
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_type");
        set => this.WithProperty("target_resource_type", value);
    }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    public TerraformProperty<string>? WindowSize
    {
        get => GetProperty<TerraformProperty<string>>("window_size");
        set => this.WithProperty("window_size", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorMetricAlertActionBlock>? Action
    {
        get => GetProperty<HashSet<AzurermMonitorMetricAlertActionBlock>>("action");
        set => this.WithProperty("action", value);
    }

    /// <summary>
    /// Block for application_insights_web_test_location_availability_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsightsWebTestLocationAvailabilityCriteria block(s) allowed")]
    public List<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>? ApplicationInsightsWebTestLocationAvailabilityCriteria
    {
        get => GetProperty<List<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>>("application_insights_web_test_location_availability_criteria");
        set => this.WithProperty("application_insights_web_test_location_availability_criteria", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorMetricAlertCriteriaBlock>? Criteria
    {
        get => GetProperty<List<AzurermMonitorMetricAlertCriteriaBlock>>("criteria");
        set => this.WithProperty("criteria", value);
    }

    /// <summary>
    /// Block for dynamic_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicCriteria block(s) allowed")]
    public List<AzurermMonitorMetricAlertDynamicCriteriaBlock>? DynamicCriteria
    {
        get => GetProperty<List<AzurermMonitorMetricAlertDynamicCriteriaBlock>>("dynamic_criteria");
        set => this.WithProperty("dynamic_criteria", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorMetricAlertTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMonitorMetricAlertTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
