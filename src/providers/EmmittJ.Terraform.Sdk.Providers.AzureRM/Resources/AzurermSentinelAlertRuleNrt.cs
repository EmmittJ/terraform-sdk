using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for alert_details_override in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleNrtAlertDetailsOverrideBlock
{
    /// <summary>
    /// The description_format attribute.
    /// </summary>
    [TerraformPropertyName("description_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DescriptionFormat { get; set; }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    [TerraformPropertyName("display_name_format")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayNameFormat { get; set; }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    [TerraformPropertyName("severity_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SeverityColumnName { get; set; }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    [TerraformPropertyName("tactics_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TacticsColumnName { get; set; }

}

/// <summary>
/// Block type for entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleNrtEntityMappingBlock
{
    /// <summary>
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    [TerraformPropertyName("entity_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EntityType { get; set; }

}

/// <summary>
/// Block type for event_grouping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleNrtEventGroupingBlock
{
    /// <summary>
    /// The aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AggregationMethod is required")]
    [TerraformPropertyName("aggregation_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AggregationMethod { get; set; }

}

/// <summary>
/// Block type for incident in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleNrtIncidentBlock
{
    /// <summary>
    /// The create_incident_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateIncidentEnabled is required")]
    [TerraformPropertyName("create_incident_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> CreateIncidentEnabled { get; set; }

}

/// <summary>
/// Block type for sentinel_entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleNrtSentinelEntityMappingBlock
{
    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    [TerraformPropertyName("column_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ColumnName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleNrtTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_nrt resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSentinelAlertRuleNrt : TerraformResource
{
    public AzurermSentinelAlertRuleNrt(string name) : base("azurerm_sentinel_alert_rule_nrt", name)
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    [TerraformPropertyName("alert_rule_template_guid")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AlertRuleTemplateGuid { get; set; }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    [TerraformPropertyName("alert_rule_template_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AlertRuleTemplateVersion { get; set; }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    [TerraformPropertyName("custom_details")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? CustomDetails { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformPropertyName("severity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Severity { get; set; }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    [TerraformPropertyName("suppression_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SuppressionDuration { get; set; }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    [TerraformPropertyName("suppression_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SuppressionEnabled { get; set; }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformPropertyName("tactics")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Tactics { get; set; }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformPropertyName("techniques")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Techniques { get; set; }

    /// <summary>
    /// Block for alert_details_override.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("alert_details_override")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleNrtAlertDetailsOverrideBlock>>? AlertDetailsOverride { get; set; }

    /// <summary>
    /// Block for entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 EntityMapping block(s) allowed")]
    [TerraformPropertyName("entity_mapping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleNrtEntityMappingBlock>>? EntityMapping { get; set; }

    /// <summary>
    /// Block for event_grouping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventGrouping is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EventGrouping block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    [TerraformPropertyName("event_grouping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleNrtEventGroupingBlock>>? EventGrouping { get; set; }

    /// <summary>
    /// Block for incident.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    [TerraformPropertyName("incident")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleNrtIncidentBlock>>? Incident { get; set; }

    /// <summary>
    /// Block for sentinel_entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 SentinelEntityMapping block(s) allowed")]
    [TerraformPropertyName("sentinel_entity_mapping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleNrtSentinelEntityMappingBlock>>? SentinelEntityMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleNrtTimeoutsBlock>? Timeouts { get; set; }

}
