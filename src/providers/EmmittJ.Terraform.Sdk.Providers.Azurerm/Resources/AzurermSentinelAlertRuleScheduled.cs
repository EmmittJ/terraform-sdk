using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for alert_details_override in AzurermSentinelAlertRuleScheduled.
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
        get => GetArgument<TerraformValue<string>>("description_format");
        set => SetArgument("description_format", value);
    }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    public TerraformValue<string>? DisplayNameFormat
    {
        get => GetArgument<TerraformValue<string>>("display_name_format");
        set => SetArgument("display_name_format", value);
    }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    public TerraformValue<string>? SeverityColumnName
    {
        get => GetArgument<TerraformValue<string>>("severity_column_name");
        set => SetArgument("severity_column_name", value);
    }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    public TerraformValue<string>? TacticsColumnName
    {
        get => GetArgument<TerraformValue<string>>("tactics_column_name");
        set => SetArgument("tactics_column_name", value);
    }

    /// <summary>
    /// DynamicProperty block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlockDynamicPropertyBlock>? DynamicProperty
    {
        get => GetArgument<TerraformList<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlockDynamicPropertyBlock>>("dynamic_property");
        set => SetArgument("dynamic_property", value);
    }

}

/// <summary>
/// Block type for dynamic_property in AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlockDynamicPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynamic_property";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for entity_mapping in AzurermSentinelAlertRuleScheduled.
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
        get => GetRequiredArgument<TerraformValue<string>>("entity_type");
        set => SetArgument("entity_type", value);
    }

    /// <summary>
    /// FieldMapping block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FieldMapping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FieldMapping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 FieldMapping block(s) allowed")]
    public required TerraformList<AzurermSentinelAlertRuleScheduledEntityMappingBlockFieldMappingBlock> FieldMapping
    {
        get => GetRequiredArgument<TerraformList<AzurermSentinelAlertRuleScheduledEntityMappingBlockFieldMappingBlock>>("field_mapping");
        set => SetArgument("field_mapping", value);
    }

}

/// <summary>
/// Block type for field_mapping in AzurermSentinelAlertRuleScheduledEntityMappingBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEntityMappingBlockFieldMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "field_mapping";

    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformValue<string> ColumnName
    {
        get => GetRequiredArgument<TerraformValue<string>>("column_name");
        set => SetArgument("column_name", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identifier is required")]
    public required TerraformValue<string> Identifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("identifier");
        set => SetArgument("identifier", value);
    }

}


/// <summary>
/// Block type for event_grouping in AzurermSentinelAlertRuleScheduled.
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
        get => GetRequiredArgument<TerraformValue<string>>("aggregation_method");
        set => SetArgument("aggregation_method", value);
    }

}


/// <summary>
/// Block type for incident in AzurermSentinelAlertRuleScheduled.
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
        get => GetRequiredArgument<TerraformValue<bool>>("create_incident_enabled");
        set => SetArgument("create_incident_enabled", value);
    }

    /// <summary>
    /// Grouping block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Grouping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Grouping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grouping block(s) allowed")]
    public required TerraformList<AzurermSentinelAlertRuleScheduledIncidentBlockGroupingBlock> Grouping
    {
        get => GetRequiredArgument<TerraformList<AzurermSentinelAlertRuleScheduledIncidentBlockGroupingBlock>>("grouping");
        set => SetArgument("grouping", value);
    }

}

/// <summary>
/// Block type for grouping in AzurermSentinelAlertRuleScheduledIncidentBlock.
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledIncidentBlockGroupingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grouping";

    /// <summary>
    /// The by_alert_details attribute.
    /// </summary>
    public TerraformList<string>? ByAlertDetails
    {
        get => GetArgument<TerraformList<string>>("by_alert_details");
        set => SetArgument("by_alert_details", value);
    }

    /// <summary>
    /// The by_custom_details attribute.
    /// </summary>
    public TerraformList<string>? ByCustomDetails
    {
        get => GetArgument<TerraformList<string>>("by_custom_details");
        set => SetArgument("by_custom_details", value);
    }

    /// <summary>
    /// The by_entities attribute.
    /// </summary>
    public TerraformList<string>? ByEntities
    {
        get => GetArgument<TerraformList<string>>("by_entities");
        set => SetArgument("by_entities", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The entity_matching_method attribute.
    /// </summary>
    public TerraformValue<string>? EntityMatchingMethod
    {
        get => GetArgument<TerraformValue<string>>("entity_matching_method");
        set => SetArgument("entity_matching_method", value);
    }

    /// <summary>
    /// The lookback_duration attribute.
    /// </summary>
    public TerraformValue<string>? LookbackDuration
    {
        get => GetArgument<TerraformValue<string>>("lookback_duration");
        set => SetArgument("lookback_duration", value);
    }

    /// <summary>
    /// The reopen_closed_incidents attribute.
    /// </summary>
    public TerraformValue<bool>? ReopenClosedIncidents
    {
        get => GetArgument<TerraformValue<bool>>("reopen_closed_incidents");
        set => SetArgument("reopen_closed_incidents", value);
    }

}


/// <summary>
/// Block type for sentinel_entity_mapping in AzurermSentinelAlertRuleScheduled.
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
        get => GetRequiredArgument<TerraformValue<string>>("column_name");
        set => SetArgument("column_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSentinelAlertRuleScheduled.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("alert_rule_template_guid");
        set => SetArgument("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public TerraformValue<string>? AlertRuleTemplateVersion
    {
        get => GetArgument<TerraformValue<string>>("alert_rule_template_version");
        set => SetArgument("alert_rule_template_version", value);
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public TerraformMap<string>? CustomDetails
    {
        get => GetArgument<TerraformMap<string>>("custom_details");
        set => SetArgument("custom_details", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => GetRequiredArgument<TerraformValue<string>>("query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    public TerraformValue<string>? QueryFrequency
    {
        get => GetArgument<TerraformValue<string>>("query_frequency");
        set => SetArgument("query_frequency", value);
    }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    public TerraformValue<string>? QueryPeriod
    {
        get => GetArgument<TerraformValue<string>>("query_period");
        set => SetArgument("query_period", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<string> Severity
    {
        get => GetRequiredArgument<TerraformValue<string>>("severity");
        set => SetArgument("severity", value);
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public TerraformValue<string>? SuppressionDuration
    {
        get => GetArgument<TerraformValue<string>>("suppression_duration");
        set => SetArgument("suppression_duration", value);
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SuppressionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("suppression_enabled");
        set => SetArgument("suppression_enabled", value);
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public TerraformSet<string>? Tactics
    {
        get => GetArgument<TerraformSet<string>>("tactics");
        set => SetArgument("tactics", value);
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public TerraformSet<string>? Techniques
    {
        get => GetArgument<TerraformSet<string>>("techniques");
        set => SetArgument("techniques", value);
    }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    public TerraformValue<string>? TriggerOperator
    {
        get => GetArgument<TerraformValue<string>>("trigger_operator");
        set => SetArgument("trigger_operator", value);
    }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    public TerraformValue<double>? TriggerThreshold
    {
        get => GetArgument<TerraformValue<double>>("trigger_threshold");
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
