using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorMetricAlertActionBlock : ITerraformBlock
{
    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    [TerraformPropertyName("action_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ActionGroupId { get; set; }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    [TerraformPropertyName("webhook_properties")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? WebhookProperties { get; set; }

}

/// <summary>
/// Block type for application_insights_web_test_location_availability_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock : ITerraformBlock
{
    /// <summary>
    /// The component_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentId is required")]
    [TerraformPropertyName("component_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComponentId { get; set; }

    /// <summary>
    /// The failed_location_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailedLocationCount is required")]
    [TerraformPropertyName("failed_location_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> FailedLocationCount { get; set; }

    /// <summary>
    /// The web_test_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebTestId is required")]
    [TerraformPropertyName("web_test_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WebTestId { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertCriteriaBlock : ITerraformBlock
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformPropertyName("aggregation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Aggregation { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformPropertyName("metric_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformPropertyName("metric_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricNamespace { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformPropertyName("operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Operator { get; set; }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    [TerraformPropertyName("skip_metric_validation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipMetricValidation { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformPropertyName("threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Threshold { get; set; }

}

/// <summary>
/// Block type for dynamic_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertDynamicCriteriaBlock : ITerraformBlock
{
    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformPropertyName("aggregation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Aggregation { get; set; }

    /// <summary>
    /// The alert_sensitivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertSensitivity is required")]
    [TerraformPropertyName("alert_sensitivity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AlertSensitivity { get; set; }

    /// <summary>
    /// The evaluation_failure_count attribute.
    /// </summary>
    [TerraformPropertyName("evaluation_failure_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? EvaluationFailureCount { get; set; }

    /// <summary>
    /// The evaluation_total_count attribute.
    /// </summary>
    [TerraformPropertyName("evaluation_total_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? EvaluationTotalCount { get; set; }

    /// <summary>
    /// The ignore_data_before attribute.
    /// </summary>
    [TerraformPropertyName("ignore_data_before")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IgnoreDataBefore { get; set; }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformPropertyName("metric_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricName { get; set; }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformPropertyName("metric_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MetricNamespace { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformPropertyName("operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Operator { get; set; }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    [TerraformPropertyName("skip_metric_validation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipMetricValidation { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorMetricAlertTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_metric_alert resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorMetricAlert : TerraformResource
{
    public AzurermMonitorMetricAlert(string name) : base("azurerm_monitor_metric_alert", name)
    {
    }

    /// <summary>
    /// The auto_mitigate attribute.
    /// </summary>
    [TerraformPropertyName("auto_mitigate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoMitigate { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Frequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Scopes { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformPropertyName("severity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Severity { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [TerraformPropertyName("target_resource_location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TargetResourceLocation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_resource_location");

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [TerraformPropertyName("target_resource_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TargetResourceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_resource_type");

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    [TerraformPropertyName("window_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WindowSize { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("action")]
    public TerraformSet<TerraformBlock<AzurermMonitorMetricAlertActionBlock>>? Action { get; set; } = new();

    /// <summary>
    /// Block for application_insights_web_test_location_availability_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsightsWebTestLocationAvailabilityCriteria block(s) allowed")]
    [TerraformPropertyName("application_insights_web_test_location_availability_criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>>? ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; } = new();

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorMetricAlertCriteriaBlock>>? Criteria { get; set; } = new();

    /// <summary>
    /// Block for dynamic_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicCriteria block(s) allowed")]
    [TerraformPropertyName("dynamic_criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorMetricAlertDynamicCriteriaBlock>>? DynamicCriteria { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorMetricAlertTimeoutsBlock>? Timeouts { get; set; } = new();

}
