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
        set => SetProperty("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? WebhookProperties
    {
        set => SetProperty("webhook_properties", value);
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
        set => SetProperty("component_id", value);
    }

    /// <summary>
    /// The failed_location_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailedLocationCount is required")]
    public required TerraformProperty<double> FailedLocationCount
    {
        set => SetProperty("failed_location_count", value);
    }

    /// <summary>
    /// The web_test_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebTestId is required")]
    public required TerraformProperty<string> WebTestId
    {
        set => SetProperty("web_test_id", value);
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
        set => SetProperty("aggregation", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        set => SetProperty("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformProperty<string> MetricNamespace
    {
        set => SetProperty("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipMetricValidation
    {
        set => SetProperty("skip_metric_validation", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformProperty<double> Threshold
    {
        set => SetProperty("threshold", value);
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
        set => SetProperty("aggregation", value);
    }

    /// <summary>
    /// The alert_sensitivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertSensitivity is required")]
    public required TerraformProperty<string> AlertSensitivity
    {
        set => SetProperty("alert_sensitivity", value);
    }

    /// <summary>
    /// The evaluation_failure_count attribute.
    /// </summary>
    public TerraformProperty<double>? EvaluationFailureCount
    {
        set => SetProperty("evaluation_failure_count", value);
    }

    /// <summary>
    /// The evaluation_total_count attribute.
    /// </summary>
    public TerraformProperty<double>? EvaluationTotalCount
    {
        set => SetProperty("evaluation_total_count", value);
    }

    /// <summary>
    /// The ignore_data_before attribute.
    /// </summary>
    public TerraformProperty<string>? IgnoreDataBefore
    {
        set => SetProperty("ignore_data_before", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        set => SetProperty("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformProperty<string> MetricNamespace
    {
        set => SetProperty("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    public required TerraformProperty<string> Operator
    {
        set => SetProperty("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipMetricValidation
    {
        set => SetProperty("skip_metric_validation", value);
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
        SetOutput("auto_mitigate");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("frequency");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("scopes");
        SetOutput("severity");
        SetOutput("tags");
        SetOutput("target_resource_location");
        SetOutput("target_resource_type");
        SetOutput("window_size");
    }

    /// <summary>
    /// The auto_mitigate attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMitigate
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_mitigate");
        set => SetProperty("auto_mitigate", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<string> Frequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("frequency");
        set => SetProperty("frequency", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public HashSet<TerraformProperty<string>> Scopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("scopes");
        set => SetProperty("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformProperty<double> Severity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformProperty<string> TargetResourceLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_resource_location");
        set => SetProperty("target_resource_location", value);
    }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformProperty<string> TargetResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_resource_type");
        set => SetProperty("target_resource_type", value);
    }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    public TerraformProperty<string> WindowSize
    {
        get => GetRequiredOutput<TerraformProperty<string>>("window_size");
        set => SetProperty("window_size", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMonitorMetricAlertActionBlock>? Action
    {
        set => SetProperty("action", value);
    }

    /// <summary>
    /// Block for application_insights_web_test_location_availability_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsightsWebTestLocationAvailabilityCriteria block(s) allowed")]
    public List<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>? ApplicationInsightsWebTestLocationAvailabilityCriteria
    {
        set => SetProperty("application_insights_web_test_location_availability_criteria", value);
    }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermMonitorMetricAlertCriteriaBlock>? Criteria
    {
        set => SetProperty("criteria", value);
    }

    /// <summary>
    /// Block for dynamic_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicCriteria block(s) allowed")]
    public List<AzurermMonitorMetricAlertDynamicCriteriaBlock>? DynamicCriteria
    {
        set => SetProperty("dynamic_criteria", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMonitorMetricAlertTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
