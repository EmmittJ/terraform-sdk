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
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorMetricAlertActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The action_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionGroupId is required")]
    [TerraformArgument("action_group_id")]
    public required TerraformValue<string> ActionGroupId
    {
        get => new TerraformReference<string>(this, "action_group_id");
        set => SetArgument("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    [TerraformArgument("webhook_properties")]
    public TerraformMap<string>? WebhookProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "webhook_properties").ResolveNodes(ctx));
        set => SetArgument("webhook_properties", value);
    }

}

/// <summary>
/// Block type for application_insights_web_test_location_availability_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_insights_web_test_location_availability_criteria";

    /// <summary>
    /// The component_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentId is required")]
    [TerraformArgument("component_id")]
    public required TerraformValue<string> ComponentId
    {
        get => new TerraformReference<string>(this, "component_id");
        set => SetArgument("component_id", value);
    }

    /// <summary>
    /// The failed_location_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailedLocationCount is required")]
    [TerraformArgument("failed_location_count")]
    public required TerraformValue<double> FailedLocationCount
    {
        get => new TerraformReference<double>(this, "failed_location_count");
        set => SetArgument("failed_location_count", value);
    }

    /// <summary>
    /// The web_test_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebTestId is required")]
    [TerraformArgument("web_test_id")]
    public required TerraformValue<string> WebTestId
    {
        get => new TerraformReference<string>(this, "web_test_id");
        set => SetArgument("web_test_id", value);
    }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "criteria";

    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformArgument("aggregation")]
    public required TerraformValue<string> Aggregation
    {
        get => new TerraformReference<string>(this, "aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformArgument("metric_name")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformArgument("metric_namespace")]
    public required TerraformValue<string> MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformArgument("operator")]
    public required TerraformValue<string> Operator
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    [TerraformArgument("skip_metric_validation")]
    public TerraformValue<bool>? SkipMetricValidation
    {
        get => new TerraformReference<bool>(this, "skip_metric_validation");
        set => SetArgument("skip_metric_validation", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformArgument("threshold")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

}

/// <summary>
/// Block type for dynamic_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertDynamicCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamic_criteria";

    /// <summary>
    /// The aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aggregation is required")]
    [TerraformArgument("aggregation")]
    public required TerraformValue<string> Aggregation
    {
        get => new TerraformReference<string>(this, "aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// The alert_sensitivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertSensitivity is required")]
    [TerraformArgument("alert_sensitivity")]
    public required TerraformValue<string> AlertSensitivity
    {
        get => new TerraformReference<string>(this, "alert_sensitivity");
        set => SetArgument("alert_sensitivity", value);
    }

    /// <summary>
    /// The evaluation_failure_count attribute.
    /// </summary>
    [TerraformArgument("evaluation_failure_count")]
    public TerraformValue<double>? EvaluationFailureCount
    {
        get => new TerraformReference<double>(this, "evaluation_failure_count");
        set => SetArgument("evaluation_failure_count", value);
    }

    /// <summary>
    /// The evaluation_total_count attribute.
    /// </summary>
    [TerraformArgument("evaluation_total_count")]
    public TerraformValue<double>? EvaluationTotalCount
    {
        get => new TerraformReference<double>(this, "evaluation_total_count");
        set => SetArgument("evaluation_total_count", value);
    }

    /// <summary>
    /// The ignore_data_before attribute.
    /// </summary>
    [TerraformArgument("ignore_data_before")]
    public TerraformValue<string>? IgnoreDataBefore
    {
        get => new TerraformReference<string>(this, "ignore_data_before");
        set => SetArgument("ignore_data_before", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformArgument("metric_name")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    [TerraformArgument("metric_namespace")]
    public required TerraformValue<string> MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformArgument("operator")]
    public required TerraformValue<string> Operator
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    [TerraformArgument("skip_metric_validation")]
    public TerraformValue<bool>? SkipMetricValidation
    {
        get => new TerraformReference<bool>(this, "skip_metric_validation");
        set => SetArgument("skip_metric_validation", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorMetricAlertTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("auto_mitigate")]
    public TerraformValue<bool>? AutoMitigate
    {
        get => new TerraformReference<bool>(this, "auto_mitigate");
        set => SetArgument("auto_mitigate", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformArgument("frequency")]
    public TerraformValue<string>? Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformArgument("scopes")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [TerraformArgument("severity")]
    public TerraformValue<double>? Severity
    {
        get => new TerraformReference<double>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [TerraformArgument("target_resource_location")]
    public TerraformValue<string> TargetResourceLocation
    {
        get => new TerraformReference<string>(this, "target_resource_location");
        set => SetArgument("target_resource_location", value);
    }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    [TerraformArgument("target_resource_type")]
    public TerraformValue<string> TargetResourceType
    {
        get => new TerraformReference<string>(this, "target_resource_type");
        set => SetArgument("target_resource_type", value);
    }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    [TerraformArgument("window_size")]
    public TerraformValue<string>? WindowSize
    {
        get => new TerraformReference<string>(this, "window_size");
        set => SetArgument("window_size", value);
    }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("action")]
    public TerraformSet<AzurermMonitorMetricAlertActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for application_insights_web_test_location_availability_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsightsWebTestLocationAvailabilityCriteria block(s) allowed")]
    [TerraformArgument("application_insights_web_test_location_availability_criteria")]
    public TerraformList<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock> ApplicationInsightsWebTestLocationAvailabilityCriteria { get; set; } = new();

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("criteria")]
    public TerraformList<AzurermMonitorMetricAlertCriteriaBlock> Criteria { get; set; } = new();

    /// <summary>
    /// Block for dynamic_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicCriteria block(s) allowed")]
    [TerraformArgument("dynamic_criteria")]
    public TerraformList<AzurermMonitorMetricAlertDynamicCriteriaBlock> DynamicCriteria { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMonitorMetricAlertTimeoutsBlock Timeouts { get; set; } = new();

}
