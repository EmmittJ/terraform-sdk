using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for action in AzurermMonitorMetricAlert.
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
    public required TerraformValue<string> ActionGroupId
    {
        get => new TerraformReference<string>(this, "action_group_id");
        set => SetArgument("action_group_id", value);
    }

    /// <summary>
    /// The webhook_properties attribute.
    /// </summary>
    public TerraformMap<string>? WebhookProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "webhook_properties").ResolveNodes(ctx));
        set => SetArgument("webhook_properties", value);
    }

}


/// <summary>
/// Block type for application_insights_web_test_location_availability_criteria in AzurermMonitorMetricAlert.
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
    public required TerraformValue<string> ComponentId
    {
        get => new TerraformReference<string>(this, "component_id");
        set => SetArgument("component_id", value);
    }

    /// <summary>
    /// The failed_location_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailedLocationCount is required")]
    public required TerraformValue<double> FailedLocationCount
    {
        get => new TerraformReference<double>(this, "failed_location_count");
        set => SetArgument("failed_location_count", value);
    }

    /// <summary>
    /// The web_test_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebTestId is required")]
    public required TerraformValue<string> WebTestId
    {
        get => new TerraformReference<string>(this, "web_test_id");
        set => SetArgument("web_test_id", value);
    }

}


/// <summary>
/// Block type for criteria in AzurermMonitorMetricAlert.
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
    public required TerraformValue<string> Aggregation
    {
        get => new TerraformReference<string>(this, "aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformValue<string> MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    public TerraformValue<bool>? SkipMetricValidation
    {
        get => new TerraformReference<bool>(this, "skip_metric_validation");
        set => SetArgument("skip_metric_validation", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    public required TerraformValue<double> Threshold
    {
        get => new TerraformReference<double>(this, "threshold");
        set => SetArgument("threshold", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorMetricAlertCriteriaBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AzurermMonitorMetricAlertCriteriaBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AzurermMonitorMetricAlertCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertCriteriaBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for dynamic_criteria in AzurermMonitorMetricAlert.
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
    public required TerraformValue<string> Aggregation
    {
        get => new TerraformReference<string>(this, "aggregation");
        set => SetArgument("aggregation", value);
    }

    /// <summary>
    /// The alert_sensitivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AlertSensitivity is required")]
    public required TerraformValue<string> AlertSensitivity
    {
        get => new TerraformReference<string>(this, "alert_sensitivity");
        set => SetArgument("alert_sensitivity", value);
    }

    /// <summary>
    /// The evaluation_failure_count attribute.
    /// </summary>
    public TerraformValue<double>? EvaluationFailureCount
    {
        get => new TerraformReference<double>(this, "evaluation_failure_count");
        set => SetArgument("evaluation_failure_count", value);
    }

    /// <summary>
    /// The evaluation_total_count attribute.
    /// </summary>
    public TerraformValue<double>? EvaluationTotalCount
    {
        get => new TerraformReference<double>(this, "evaluation_total_count");
        set => SetArgument("evaluation_total_count", value);
    }

    /// <summary>
    /// The ignore_data_before attribute.
    /// </summary>
    public TerraformValue<string>? IgnoreDataBefore
    {
        get => new TerraformReference<string>(this, "ignore_data_before");
        set => SetArgument("ignore_data_before", value);
    }

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => new TerraformReference<string>(this, "metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// The metric_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricNamespace is required")]
    public required TerraformValue<string> MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The skip_metric_validation attribute.
    /// </summary>
    public TerraformValue<bool>? SkipMetricValidation
    {
        get => new TerraformReference<bool>(this, "skip_metric_validation");
        set => SetArgument("skip_metric_validation", value);
    }

    /// <summary>
    /// Dimension block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorMetricAlertDynamicCriteriaBlockDimensionBlock>? Dimension
    {
        get => GetArgument<TerraformList<AzurermMonitorMetricAlertDynamicCriteriaBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AzurermMonitorMetricAlertDynamicCriteriaBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorMetricAlertDynamicCriteriaBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorMetricAlert.
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_monitor_metric_alert Terraform resource.
/// Manages a azurerm_monitor_metric_alert resource.
/// </summary>
public partial class AzurermMonitorMetricAlert(string name) : TerraformResource("azurerm_monitor_metric_alert", name)
{
    /// <summary>
    /// The auto_mitigate attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMitigate
    {
        get => new TerraformReference<bool>(this, "auto_mitigate");
        set => SetArgument("auto_mitigate", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => new TerraformReference<string>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    public required TerraformSet<string> Scopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scopes").ResolveNodes(ctx));
        set => SetArgument("scopes", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    public TerraformValue<double>? Severity
    {
        get => new TerraformReference<double>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The location of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformValue<string> TargetResourceLocation
    {
        get => new TerraformReference<string>(this, "target_resource_location");
        set => SetArgument("target_resource_location", value);
    }

    /// <summary>
    /// The resource type (e.g. Microsoft.Compute/virtualMachines) of the target pluginsdk. Required when using subscription, resource group scope or multiple scopes.
    /// </summary>
    public TerraformValue<string> TargetResourceType
    {
        get => new TerraformReference<string>(this, "target_resource_type");
        set => SetArgument("target_resource_type", value);
    }

    /// <summary>
    /// The window_size attribute.
    /// </summary>
    public TerraformValue<string>? WindowSize
    {
        get => new TerraformReference<string>(this, "window_size");
        set => SetArgument("window_size", value);
    }

    /// <summary>
    /// Action block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorMetricAlertActionBlock>? Action
    {
        get => GetArgument<TerraformSet<AzurermMonitorMetricAlertActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// ApplicationInsightsWebTestLocationAvailabilityCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsightsWebTestLocationAvailabilityCriteria block(s) allowed")]
    public TerraformList<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>? ApplicationInsightsWebTestLocationAvailabilityCriteria
    {
        get => GetArgument<TerraformList<AzurermMonitorMetricAlertApplicationInsightsWebTestLocationAvailabilityCriteriaBlock>>("application_insights_web_test_location_availability_criteria");
        set => SetArgument("application_insights_web_test_location_availability_criteria", value);
    }

    /// <summary>
    /// Criteria block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorMetricAlertCriteriaBlock>? Criteria
    {
        get => GetArgument<TerraformList<AzurermMonitorMetricAlertCriteriaBlock>>("criteria");
        set => SetArgument("criteria", value);
    }

    /// <summary>
    /// DynamicCriteria block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DynamicCriteria block(s) allowed")]
    public TerraformList<AzurermMonitorMetricAlertDynamicCriteriaBlock>? DynamicCriteria
    {
        get => GetArgument<TerraformList<AzurermMonitorMetricAlertDynamicCriteriaBlock>>("dynamic_criteria");
        set => SetArgument("dynamic_criteria", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorMetricAlertTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorMetricAlertTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
