using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for alert_details_override in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleNrtAlertDetailsOverrideBlock : TerraformBlock
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
public class AzurermSentinelAlertRuleNrtEntityMappingBlock : TerraformBlock
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
public class AzurermSentinelAlertRuleNrtEventGroupingBlock : TerraformBlock
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
public class AzurermSentinelAlertRuleNrtIncidentBlock : TerraformBlock
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
public class AzurermSentinelAlertRuleNrtSentinelEntityMappingBlock : TerraformBlock
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
public class AzurermSentinelAlertRuleNrtTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_alert_rule_nrt Terraform resource.
/// Manages a azurerm_sentinel_alert_rule_nrt resource.
/// </summary>
public partial class AzurermSentinelAlertRuleNrt(string name) : TerraformResource("azurerm_sentinel_alert_rule_nrt", name)
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
    /// AlertDetailsOverride block (nesting mode: list).
    /// </summary>
    public AzurermSentinelAlertRuleNrtAlertDetailsOverrideBlock? AlertDetailsOverride
    {
        get => GetArgument<AzurermSentinelAlertRuleNrtAlertDetailsOverrideBlock>("alert_details_override");
        set => SetArgument("alert_details_override", value);
    }

    /// <summary>
    /// EntityMapping block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EntityMapping block(s) allowed")]
    public AzurermSentinelAlertRuleNrtEntityMappingBlock? EntityMapping
    {
        get => GetArgument<AzurermSentinelAlertRuleNrtEntityMappingBlock>("entity_mapping");
        set => SetArgument("entity_mapping", value);
    }

    /// <summary>
    /// EventGrouping block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventGrouping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EventGrouping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    public required AzurermSentinelAlertRuleNrtEventGroupingBlock EventGrouping
    {
        get => GetRequiredArgument<AzurermSentinelAlertRuleNrtEventGroupingBlock>("event_grouping");
        set => SetArgument("event_grouping", value);
    }

    /// <summary>
    /// Incident block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    public AzurermSentinelAlertRuleNrtIncidentBlock? Incident
    {
        get => GetArgument<AzurermSentinelAlertRuleNrtIncidentBlock>("incident");
        set => SetArgument("incident", value);
    }

    /// <summary>
    /// SentinelEntityMapping block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 SentinelEntityMapping block(s) allowed")]
    public AzurermSentinelAlertRuleNrtSentinelEntityMappingBlock? SentinelEntityMapping
    {
        get => GetArgument<AzurermSentinelAlertRuleNrtSentinelEntityMappingBlock>("sentinel_entity_mapping");
        set => SetArgument("sentinel_entity_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelAlertRuleNrtTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelAlertRuleNrtTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
