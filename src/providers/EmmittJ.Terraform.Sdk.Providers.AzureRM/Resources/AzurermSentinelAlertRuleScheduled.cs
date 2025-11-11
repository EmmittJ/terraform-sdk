using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for alert_details_override in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock : TerraformBlockBase
{
    /// <summary>
    /// The description_format attribute.
    /// </summary>
    [TerraformProperty("description_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DescriptionFormat { get; set; }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    [TerraformProperty("display_name_format")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayNameFormat { get; set; }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    [TerraformProperty("severity_column_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SeverityColumnName { get; set; }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    [TerraformProperty("tactics_column_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TacticsColumnName { get; set; }

}

/// <summary>
/// Block type for entity_mapping in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleScheduledEntityMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    [TerraformProperty("entity_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EntityType { get; set; }

}

/// <summary>
/// Block type for event_grouping in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleScheduledEventGroupingBlock : TerraformBlockBase
{
    /// <summary>
    /// The aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AggregationMethod is required")]
    [TerraformProperty("aggregation_method")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AggregationMethod { get; set; }

}

/// <summary>
/// Block type for incident in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleScheduledIncidentBlock : TerraformBlockBase
{
    /// <summary>
    /// The create_incident_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateIncidentEnabled is required")]
    [TerraformProperty("create_incident_enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> CreateIncidentEnabled { get; set; }

}

/// <summary>
/// Block type for sentinel_entity_mapping in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    [TerraformProperty("column_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ColumnName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSentinelAlertRuleScheduledTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_sentinel_alert_rule_scheduled resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSentinelAlertRuleScheduled : TerraformResource
{
    public AzurermSentinelAlertRuleScheduled(string name) : base("azurerm_sentinel_alert_rule_scheduled", name)
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    [TerraformProperty("alert_rule_template_guid")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AlertRuleTemplateGuid { get; set; }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    [TerraformProperty("alert_rule_template_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AlertRuleTemplateVersion { get; set; }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    [TerraformProperty("custom_details")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? CustomDetails { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    [TerraformProperty("log_analytics_workspace_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformProperty("query")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    [TerraformProperty("query_frequency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? QueryFrequency { get; set; }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    [TerraformProperty("query_period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? QueryPeriod { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformProperty("severity")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Severity { get; set; }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    [TerraformProperty("suppression_duration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SuppressionDuration { get; set; }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    [TerraformProperty("suppression_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SuppressionEnabled { get; set; }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    [TerraformProperty("tactics")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Tactics { get; set; }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    [TerraformProperty("techniques")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Techniques { get; set; }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    [TerraformProperty("trigger_operator")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TriggerOperator { get; set; }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    [TerraformProperty("trigger_threshold")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? TriggerThreshold { get; set; }

    /// <summary>
    /// Block for alert_details_override.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("alert_details_override")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>>? AlertDetailsOverride { get; set; }

    /// <summary>
    /// Block for entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 EntityMapping block(s) allowed")]
    [TerraformProperty("entity_mapping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledEntityMappingBlock>>? EntityMapping { get; set; }

    /// <summary>
    /// Block for event_grouping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    [TerraformProperty("event_grouping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledEventGroupingBlock>>? EventGrouping { get; set; }

    /// <summary>
    /// Block for incident.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    [TerraformProperty("incident")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledIncidentBlock>>? Incident { get; set; }

    /// <summary>
    /// Block for sentinel_entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 SentinelEntityMapping block(s) allowed")]
    [TerraformProperty("sentinel_entity_mapping")]
    public TerraformList<TerraformBlock<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>>? SentinelEntityMapping { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSentinelAlertRuleScheduledTimeoutsBlock>? Timeouts { get; set; }

}
