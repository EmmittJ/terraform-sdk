using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for alert_details_override in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock : ITerraformBlock
{
    /// <summary>
    /// The description_format attribute.
    /// </summary>
    [TerraformPropertyName("description_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DescriptionFormat { get; set; }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    [TerraformPropertyName("display_name_format")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayNameFormat { get; set; }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    [TerraformPropertyName("severity_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SeverityColumnName { get; set; }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    [TerraformPropertyName("tactics_column_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TacticsColumnName { get; set; }

}

/// <summary>
/// Block type for entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEntityMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    [TerraformPropertyName("entity_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EntityType { get; set; }

}

/// <summary>
/// Block type for event_grouping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEventGroupingBlock : ITerraformBlock
{
    /// <summary>
    /// The aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AggregationMethod is required")]
    [TerraformPropertyName("aggregation_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AggregationMethod { get; set; }

}

/// <summary>
/// Block type for incident in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledIncidentBlock : ITerraformBlock
{
    /// <summary>
    /// The create_incident_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateIncidentEnabled is required")]
    [TerraformPropertyName("create_incident_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> CreateIncidentEnabled { get; set; }

}

/// <summary>
/// Block type for sentinel_entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    [TerraformPropertyName("column_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ColumnName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleScheduledTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_sentinel_alert_rule_scheduled resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSentinelAlertRuleScheduled : TerraformResource
{
    public AzurermSentinelAlertRuleScheduled(string name) : base("azurerm_sentinel_alert_rule_scheduled", name)
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    [TerraformPropertyName("alert_rule_template_guid")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AlertRuleTemplateGuid { get; set; }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    [TerraformPropertyName("alert_rule_template_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AlertRuleTemplateVersion { get; set; }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    [TerraformPropertyName("custom_details")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? CustomDetails { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Query { get; set; }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    [TerraformPropertyName("query_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryFrequency { get; set; }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    [TerraformPropertyName("query_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? QueryPeriod { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformPropertyName("severity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Severity { get; set; }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    [TerraformPropertyName("suppression_duration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SuppressionDuration { get; set; }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    [TerraformPropertyName("suppression_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SuppressionEnabled { get; set; }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformPropertyName("tactics")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Tactics { get; set; }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformPropertyName("techniques")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Techniques { get; set; }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    [TerraformPropertyName("trigger_operator")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TriggerOperator { get; set; }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    [TerraformPropertyName("trigger_threshold")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? TriggerThreshold { get; set; }

    /// <summary>
    /// Block for alert_details_override.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("alert_details_override")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>>? AlertDetailsOverride { get; set; } = new();

    /// <summary>
    /// Block for entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 EntityMapping block(s) allowed")]
    [TerraformPropertyName("entity_mapping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledEntityMappingBlock>>? EntityMapping { get; set; } = new();

    /// <summary>
    /// Block for event_grouping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    [TerraformPropertyName("event_grouping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledEventGroupingBlock>>? EventGrouping { get; set; } = new();

    /// <summary>
    /// Block for incident.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    [TerraformPropertyName("incident")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledIncidentBlock>>? Incident { get; set; } = new();

    /// <summary>
    /// Block for sentinel_entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 SentinelEntityMapping block(s) allowed")]
    [TerraformPropertyName("sentinel_entity_mapping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>>? SentinelEntityMapping { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleScheduledTimeoutsBlock>? Timeouts { get; set; } = new();

}
