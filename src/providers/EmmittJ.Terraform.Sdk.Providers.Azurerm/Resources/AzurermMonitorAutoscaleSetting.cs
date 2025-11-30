using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for notification in AzurermMonitorAutoscaleSetting.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification";

    /// <summary>
    /// Email block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Email block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingNotificationBlockEmailBlock>? Email
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingNotificationBlockEmailBlock>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// Webhook block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorAutoscaleSettingNotificationBlockWebhookBlock>? Webhook
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingNotificationBlockWebhookBlock>>("webhook");
        set => SetArgument("webhook", value);
    }

}

/// <summary>
/// Block type for email in AzurermMonitorAutoscaleSettingNotificationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingNotificationBlockEmailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email";

    /// <summary>
    /// The custom_emails attribute.
    /// </summary>
    public TerraformList<string>? CustomEmails
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "custom_emails").ResolveNodes(ctx));
        set => SetArgument("custom_emails", value);
    }

    /// <summary>
    /// The send_to_subscription_administrator attribute.
    /// </summary>
    public TerraformValue<bool>? SendToSubscriptionAdministrator
    {
        get => new TerraformReference<bool>(this, "send_to_subscription_administrator");
        set => SetArgument("send_to_subscription_administrator", value);
    }

    /// <summary>
    /// The send_to_subscription_co_administrator attribute.
    /// </summary>
    public TerraformValue<bool>? SendToSubscriptionCoAdministrator
    {
        get => new TerraformReference<bool>(this, "send_to_subscription_co_administrator");
        set => SetArgument("send_to_subscription_co_administrator", value);
    }

}

/// <summary>
/// Block type for webhook in AzurermMonitorAutoscaleSettingNotificationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingNotificationBlockWebhookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "webhook";

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// The service_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceUri is required")]
    public required TerraformValue<string> ServiceUri
    {
        get => new TerraformReference<string>(this, "service_uri");
        set => SetArgument("service_uri", value);
    }

}


/// <summary>
/// Block type for predictive in AzurermMonitorAutoscaleSetting.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingPredictiveBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "predictive";

    /// <summary>
    /// The look_ahead_time attribute.
    /// </summary>
    public TerraformValue<string>? LookAheadTime
    {
        get => new TerraformReference<string>(this, "look_ahead_time");
        set => SetArgument("look_ahead_time", value);
    }

    /// <summary>
    /// The scale_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleMode is required")]
    public required TerraformValue<string> ScaleMode
    {
        get => new TerraformReference<string>(this, "scale_mode");
        set => SetArgument("scale_mode", value);
    }

}


/// <summary>
/// Block type for profile in AzurermMonitorAutoscaleSetting.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "profile";

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
    /// Capacity block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Capacity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Capacity block(s) allowed")]
    public required TerraformList<AzurermMonitorAutoscaleSettingProfileBlockCapacityBlock> Capacity
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockCapacityBlock>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// FixedDate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FixedDate block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingProfileBlockFixedDateBlock>? FixedDate
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockFixedDateBlock>>("fixed_date");
        set => SetArgument("fixed_date", value);
    }

    /// <summary>
    /// Recurrence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Recurrence block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRecurrenceBlock>? Recurrence
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRecurrenceBlock>>("recurrence");
        set => SetArgument("recurrence", value);
    }

    /// <summary>
    /// Rule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Rule block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for capacity in AzurermMonitorAutoscaleSettingProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockCapacityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity";

    /// <summary>
    /// The default attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAttribute is required")]
    public required TerraformValue<double> DefaultAttribute
    {
        get => new TerraformReference<double>(this, "default");
        set => SetArgument("default", value);
    }

    /// <summary>
    /// The maximum attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Maximum is required")]
    public required TerraformValue<double> Maximum
    {
        get => new TerraformReference<double>(this, "maximum");
        set => SetArgument("maximum", value);
    }

    /// <summary>
    /// The minimum attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minimum is required")]
    public required TerraformValue<double> Minimum
    {
        get => new TerraformReference<double>(this, "minimum");
        set => SetArgument("minimum", value);
    }

}

/// <summary>
/// Block type for fixed_date in AzurermMonitorAutoscaleSettingProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockFixedDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_date";

    /// <summary>
    /// The end attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "End is required")]
    public required TerraformValue<string> End
    {
        get => new TerraformReference<string>(this, "end");
        set => SetArgument("end", value);
    }

    /// <summary>
    /// The start attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Start is required")]
    public required TerraformValue<string> Start
    {
        get => new TerraformReference<string>(this, "start");
        set => SetArgument("start", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

}

/// <summary>
/// Block type for recurrence in AzurermMonitorAutoscaleSettingProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockRecurrenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recurrence";

    /// <summary>
    /// The days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Days is required")]
    public TerraformList<string>? Days
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "days").ResolveNodes(ctx));
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The hours attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hours is required")]
    public TerraformList<double>? Hours
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "hours").ResolveNodes(ctx));
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// The minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Minutes is required")]
    public TerraformList<double>? Minutes
    {
        get => TerraformList<double>.Lazy(ctx => new TerraformReference<TerraformList<double>>(this, "minutes").ResolveNodes(ctx));
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => new TerraformReference<string>(this, "timezone");
        set => SetArgument("timezone", value);
    }

}

/// <summary>
/// Block type for rule in AzurermMonitorAutoscaleSettingProfileBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// MetricTrigger block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTrigger is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MetricTrigger block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetricTrigger block(s) allowed")]
    public required TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlock> MetricTrigger
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlock>>("metric_trigger");
        set => SetArgument("metric_trigger", value);
    }

    /// <summary>
    /// ScaleAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ScaleAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScaleAction block(s) allowed")]
    public required TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlockScaleActionBlock> ScaleAction
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlockScaleActionBlock>>("scale_action");
        set => SetArgument("scale_action", value);
    }

}

/// <summary>
/// Block type for metric_trigger in AzurermMonitorAutoscaleSettingProfileBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_trigger";

    /// <summary>
    /// The divide_by_instance_count attribute.
    /// </summary>
    public TerraformValue<bool>? DivideByInstanceCount
    {
        get => new TerraformReference<bool>(this, "divide_by_instance_count");
        set => SetArgument("divide_by_instance_count", value);
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
    public TerraformValue<string>? MetricNamespace
    {
        get => new TerraformReference<string>(this, "metric_namespace");
        set => SetArgument("metric_namespace", value);
    }

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricResourceId is required")]
    public required TerraformValue<string> MetricResourceId
    {
        get => new TerraformReference<string>(this, "metric_resource_id");
        set => SetArgument("metric_resource_id", value);
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
    /// The statistic attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statistic is required")]
    public required TerraformValue<string> Statistic
    {
        get => new TerraformReference<string>(this, "statistic");
        set => SetArgument("statistic", value);
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
    /// The time_aggregation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregation is required")]
    public required TerraformValue<string> TimeAggregation
    {
        get => new TerraformReference<string>(this, "time_aggregation");
        set => SetArgument("time_aggregation", value);
    }

    /// <summary>
    /// The time_grain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeGrain is required")]
    public required TerraformValue<string> TimeGrain
    {
        get => new TerraformReference<string>(this, "time_grain");
        set => SetArgument("time_grain", value);
    }

    /// <summary>
    /// The time_window attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeWindow is required")]
    public required TerraformValue<string> TimeWindow
    {
        get => new TerraformReference<string>(this, "time_window");
        set => SetArgument("time_window", value);
    }

    /// <summary>
    /// Dimensions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlockDimensionsBlock>? Dimensions
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlockDimensionsBlock>>("dimensions");
        set => SetArgument("dimensions", value);
    }

}

/// <summary>
/// Block type for dimensions in AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockRuleBlockMetricTriggerBlockDimensionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimensions";

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
/// Block type for scale_action in AzurermMonitorAutoscaleSettingProfileBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermMonitorAutoscaleSettingProfileBlockRuleBlockScaleActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scale_action";

    /// <summary>
    /// The cooldown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cooldown is required")]
    public required TerraformValue<string> Cooldown
    {
        get => new TerraformReference<string>(this, "cooldown");
        set => SetArgument("cooldown", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => new TerraformReference<string>(this, "direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => new TerraformReference<double>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorAutoscaleSetting.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAutoscaleSettingTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_autoscale_setting Terraform resource.
/// Manages a azurerm_monitor_autoscale_setting resource.
/// </summary>
public partial class AzurermMonitorAutoscaleSetting(string name) : TerraformResource("azurerm_monitor_autoscale_setting", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// Notification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Notification block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingNotificationBlock>? Notification
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingNotificationBlock>>("notification");
        set => SetArgument("notification", value);
    }

    /// <summary>
    /// Predictive block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Predictive block(s) allowed")]
    public TerraformList<AzurermMonitorAutoscaleSettingPredictiveBlock>? Predictive
    {
        get => GetArgument<TerraformList<AzurermMonitorAutoscaleSettingPredictiveBlock>>("predictive");
        set => SetArgument("predictive", value);
    }

    /// <summary>
    /// Profile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Profile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Profile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Profile block(s) allowed")]
    public required TerraformList<AzurermMonitorAutoscaleSettingProfileBlock> Profile
    {
        get => GetRequiredArgument<TerraformList<AzurermMonitorAutoscaleSettingProfileBlock>>("profile");
        set => SetArgument("profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorAutoscaleSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorAutoscaleSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
