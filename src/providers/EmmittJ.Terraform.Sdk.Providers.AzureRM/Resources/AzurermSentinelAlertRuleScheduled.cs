using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for alert_details_override in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "alert_details_override";

    /// <summary>
    /// The description_format attribute.
    /// </summary>
    public TerraformValue<string>? DescriptionFormat
    {
        get => new TerraformReference<string>(this, "description_format");
        set => SetArgument("description_format", value);
    }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    public TerraformValue<string>? DisplayNameFormat
    {
        get => new TerraformReference<string>(this, "display_name_format");
        set => SetArgument("display_name_format", value);
    }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    public TerraformValue<string>? SeverityColumnName
    {
        get => new TerraformReference<string>(this, "severity_column_name");
        set => SetArgument("severity_column_name", value);
    }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    public TerraformValue<string>? TacticsColumnName
    {
        get => new TerraformReference<string>(this, "tactics_column_name");
        set => SetArgument("tactics_column_name", value);
    }

}

/// <summary>
/// Block type for entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEntityMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entity_mapping";

    /// <summary>
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    public required TerraformValue<string> EntityType
    {
        get => new TerraformReference<string>(this, "entity_type");
        set => SetArgument("entity_type", value);
    }

}

/// <summary>
/// Block type for event_grouping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEventGroupingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_grouping";

    /// <summary>
    /// The aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AggregationMethod is required")]
    public required TerraformValue<string> AggregationMethod
    {
        get => new TerraformReference<string>(this, "aggregation_method");
        set => SetArgument("aggregation_method", value);
    }

}

/// <summary>
/// Block type for incident in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledIncidentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "incident";

    /// <summary>
    /// The create_incident_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateIncidentEnabled is required")]
    public required TerraformValue<bool> CreateIncidentEnabled
    {
        get => new TerraformReference<bool>(this, "create_incident_enabled");
        set => SetArgument("create_incident_enabled", value);
    }

}

/// <summary>
/// Block type for sentinel_entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sentinel_entity_mapping";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => new TerraformReference<string>(this, "column_name");
        set => SetArgument("column_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleScheduledTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_alert_rule_scheduled Terraform resource.
/// Manages a azurerm_sentinel_alert_rule_scheduled resource.
/// </summary>
public partial class AzurermSentinelAlertRuleScheduled(string name) : TerraformResource("azurerm_sentinel_alert_rule_scheduled", name)
{
    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformValue<string>? AlertRuleTemplateGuid
    {
        get => new TerraformReference<string>(this, "alert_rule_template_guid");
        set => SetArgument("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public TerraformValue<string>? AlertRuleTemplateVersion
    {
        get => new TerraformReference<string>(this, "alert_rule_template_version");
        set => SetArgument("alert_rule_template_version", value);
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public TerraformMap<string>? CustomDetails
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "custom_details").ResolveNodes(ctx));
        set => SetArgument("custom_details", value);
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
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
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    public TerraformValue<string>? QueryFrequency
    {
        get => new TerraformReference<string>(this, "query_frequency");
        set => SetArgument("query_frequency", value);
    }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    public TerraformValue<string>? QueryPeriod
    {
        get => new TerraformReference<string>(this, "query_period");
        set => SetArgument("query_period", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<string> Severity
    {
        get => new TerraformReference<string>(this, "severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public TerraformValue<string>? SuppressionDuration
    {
        get => new TerraformReference<string>(this, "suppression_duration");
        set => SetArgument("suppression_duration", value);
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SuppressionEnabled
    {
        get => new TerraformReference<bool>(this, "suppression_enabled");
        set => SetArgument("suppression_enabled", value);
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformSet<string>? Tactics
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "tactics").ResolveNodes(ctx));
        set => SetArgument("tactics", value);
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformSet<string>? Techniques
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "techniques").ResolveNodes(ctx));
        set => SetArgument("techniques", value);
    }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    public TerraformValue<string>? TriggerOperator
    {
        get => new TerraformReference<string>(this, "trigger_operator");
        set => SetArgument("trigger_operator", value);
    }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    public TerraformValue<double>? TriggerThreshold
    {
        get => new TerraformReference<double>(this, "trigger_threshold");
        set => SetArgument("trigger_threshold", value);
    }

    /// <summary>
    /// AlertDetailsOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>? AlertDetailsOverride
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>>("alert_details_override");
        set => SetArgument("alert_details_override", value);
    }

    /// <summary>
    /// EntityMapping block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 EntityMapping block(s) allowed")]
    public TerraformList<AzurermSentinelAlertRuleScheduledEntityMappingBlock>? EntityMapping
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleScheduledEntityMappingBlock>>("entity_mapping");
        set => SetArgument("entity_mapping", value);
    }

    /// <summary>
    /// EventGrouping block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    public TerraformList<AzurermSentinelAlertRuleScheduledEventGroupingBlock>? EventGrouping
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleScheduledEventGroupingBlock>>("event_grouping");
        set => SetArgument("event_grouping", value);
    }

    /// <summary>
    /// Incident block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    public TerraformList<AzurermSentinelAlertRuleScheduledIncidentBlock>? Incident
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleScheduledIncidentBlock>>("incident");
        set => SetArgument("incident", value);
    }

    /// <summary>
    /// SentinelEntityMapping block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 SentinelEntityMapping block(s) allowed")]
    public TerraformList<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>? SentinelEntityMapping
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>>("sentinel_entity_mapping");
        set => SetArgument("sentinel_entity_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleScheduledTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleScheduledTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
