using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMonitorMetricAlertActionBlock : TerraformBlockBase
{
    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    [TerraformProperty("action_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ActionGroupId { get; set; }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    [TerraformProperty("webhook_properties")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? WebhookProperties { get; set; }

}

/// <summary>
/// Block type for application_insights_web_test_location_availability_criteria in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock : TerraformBlockBase
{
    /// <summary>
    /// The component_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentId is required")]
    [TerraformProperty("component_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ComponentId { get; set; }

    /// <summary>
    /// The failed_location_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailedLocationCount is required")]
    [TerraformProperty("failed_location_count")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> FailedLocationCount { get; set; }

    /// <summary>
    /// The web_test_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebTestId is required")]
    [TerraformProperty("web_test_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WebTestId { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorMetricAlertCriteriaBlock : TerraformBlockBase
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformProperty("aggregation")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Aggregation { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformProperty("metric_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricNamespace { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformProperty("operator")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    [TerraformProperty("skip_metric_validation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipMetricValidation { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformProperty("threshold")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Threshold { get; set; }

}

/// <summary>
/// Block type for dynamic_criteria in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorMetricAlertDynamicCriteriaBlock : TerraformBlockBase
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformProperty("aggregation")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Aggregation { get; set; }

    /// <summary>
    /// The alert_sensitivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertSensitivity is required")]
    [TerraformProperty("alert_sensitivity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AlertSensitivity { get; set; }

    /// <summary>
    /// The evaluation_failure_count attribute.
    /// </summary>
    [TerraformProperty("evaluation_failure_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EvaluationFailureCount { get; set; }

    /// <summary>
    /// The evaluation_total_count attribute.
    /// </summary>
    [TerraformProperty("evaluation_total_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? EvaluationTotalCount { get; set; }

    /// <summary>
    /// The ignore_data_before attribute.
    /// </summary>
    [TerraformProperty("ignore_data_before")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IgnoreDataBefore { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformProperty("metric_namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricNamespace { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformProperty("operator")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    [TerraformProperty("skip_metric_validation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipMetricValidation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorMetricAlertTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_metric_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMonitorMetricAlert : TerraformResource
{
    public AzurermMonitorMetricAlert(string name) : base("azurerm_monitor_metric_alert", name)
    {
    }

    /// <summary>
    /// The auto_mitigate attribute.
    /// </summary>
    [TerraformProperty("auto_mitigate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoMitigate { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformProperty("frequency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Scopes { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformProperty("severity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Severity { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [TerraformProperty("target_resource_location")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TargetResourceLocation { get; set; }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [TerraformProperty("target_resource_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TargetResourceType { get; set; }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    [TerraformProperty("window_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WindowSize { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("action")]
    public TerraformSet<TerraformBlock<AzurermMonitorMetricAlertActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for application_insights_web_test_location_availability_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsightsWebTestLocationAvailabilityCriteria block(s) allowed")]
    [TerraformProperty("application_insights_web_test_location_availability_criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>>? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorMetricAlertCriteriaBlock>>? Criteria { get; set; }

    /// <summary>
    /// Block for dynamic_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicCriteria block(s) allowed")]
    [TerraformProperty("dynamic_criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorMetricAlertDynamicCriteriaBlock>>? DynamicCriteria { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorMetricAlertTimeoutsBlock>? Timeouts { get; set; }

}
