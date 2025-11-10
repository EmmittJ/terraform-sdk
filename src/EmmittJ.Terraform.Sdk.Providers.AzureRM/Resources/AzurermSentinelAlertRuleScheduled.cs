using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for alert_details_override in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock : TerraformBlock
{
    /// <summary>
    /// The description_format attribute.
    /// </summary>
    public TerraformProperty<string>? DescriptionFormat
    {
        get => GetProperty<TerraformProperty<string>>("description_format");
        set => WithProperty("description_format", value);
    }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayNameFormat
    {
        get => GetProperty<TerraformProperty<string>>("display_name_format");
        set => WithProperty("display_name_format", value);
    }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? SeverityColumnName
    {
        get => GetProperty<TerraformProperty<string>>("severity_column_name");
        set => WithProperty("severity_column_name", value);
    }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? TacticsColumnName
    {
        get => GetProperty<TerraformProperty<string>>("tactics_column_name");
        set => WithProperty("tactics_column_name", value);
    }

}

/// <summary>
/// Block type for entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEntityMappingBlock : TerraformBlock
{
    /// <summary>
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    public required TerraformProperty<string> EntityType
    {
        get => GetProperty<TerraformProperty<string>>("entity_type");
        set => WithProperty("entity_type", value);
    }

}

/// <summary>
/// Block type for event_grouping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledEventGroupingBlock : TerraformBlock
{
    /// <summary>
    /// The aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AggregationMethod is required")]
    public required TerraformProperty<string> AggregationMethod
    {
        get => GetProperty<TerraformProperty<string>>("aggregation_method");
        set => WithProperty("aggregation_method", value);
    }

}

/// <summary>
/// Block type for incident in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledIncidentBlock : TerraformBlock
{
    /// <summary>
    /// The create_incident_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreateIncidentEnabled is required")]
    public required TerraformProperty<bool> CreateIncidentEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("create_incident_enabled");
        set => WithProperty("create_incident_enabled", value);
    }

}

/// <summary>
/// Block type for sentinel_entity_mapping in .
/// Nesting mode: list
/// </summary>
public class AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock : TerraformBlock
{
    /// <summary>
    /// The column_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColumnName is required")]
    public required TerraformProperty<string> ColumnName
    {
        get => GetProperty<TerraformProperty<string>>("column_name");
        set => WithProperty("column_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelAlertRuleScheduledTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_scheduled resource.
/// </summary>
public class AzurermSentinelAlertRuleScheduled : TerraformResource
{
    public AzurermSentinelAlertRuleScheduled(string name) : base("azurerm_sentinel_alert_rule_scheduled", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformProperty<string>? AlertRuleTemplateGuid
    {
        get => GetProperty<TerraformProperty<string>>("alert_rule_template_guid");
        set => this.WithProperty("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public TerraformProperty<string>? AlertRuleTemplateVersion
    {
        get => GetProperty<TerraformProperty<string>>("alert_rule_template_version");
        set => this.WithProperty("alert_rule_template_version", value);
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CustomDetails
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("custom_details");
        set => this.WithProperty("custom_details", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetProperty<TerraformProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    public TerraformProperty<string>? QueryFrequency
    {
        get => GetProperty<TerraformProperty<string>>("query_frequency");
        set => this.WithProperty("query_frequency", value);
    }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    public TerraformProperty<string>? QueryPeriod
    {
        get => GetProperty<TerraformProperty<string>>("query_period");
        set => this.WithProperty("query_period", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformProperty<string> Severity
    {
        get => GetProperty<TerraformProperty<string>>("severity");
        set => this.WithProperty("severity", value);
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public TerraformProperty<string>? SuppressionDuration
    {
        get => GetProperty<TerraformProperty<string>>("suppression_duration");
        set => this.WithProperty("suppression_duration", value);
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SuppressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("suppression_enabled");
        set => this.WithProperty("suppression_enabled", value);
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Tactics
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("tactics");
        set => this.WithProperty("tactics", value);
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Techniques
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("techniques");
        set => this.WithProperty("techniques", value);
    }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    public TerraformProperty<string>? TriggerOperator
    {
        get => GetProperty<TerraformProperty<string>>("trigger_operator");
        set => this.WithProperty("trigger_operator", value);
    }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    public TerraformProperty<double>? TriggerThreshold
    {
        get => GetProperty<TerraformProperty<double>>("trigger_threshold");
        set => this.WithProperty("trigger_threshold", value);
    }

    /// <summary>
    /// Block for alert_details_override.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>? AlertDetailsOverride
    {
        get => GetProperty<List<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>>("alert_details_override");
        set => this.WithProperty("alert_details_override", value);
    }

    /// <summary>
    /// Block for entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 EntityMapping block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledEntityMappingBlock>? EntityMapping
    {
        get => GetProperty<List<AzurermSentinelAlertRuleScheduledEntityMappingBlock>>("entity_mapping");
        set => this.WithProperty("entity_mapping", value);
    }

    /// <summary>
    /// Block for event_grouping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledEventGroupingBlock>? EventGrouping
    {
        get => GetProperty<List<AzurermSentinelAlertRuleScheduledEventGroupingBlock>>("event_grouping");
        set => this.WithProperty("event_grouping", value);
    }

    /// <summary>
    /// Block for incident.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledIncidentBlock>? Incident
    {
        get => GetProperty<List<AzurermSentinelAlertRuleScheduledIncidentBlock>>("incident");
        set => this.WithProperty("incident", value);
    }

    /// <summary>
    /// Block for sentinel_entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 SentinelEntityMapping block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>? SentinelEntityMapping
    {
        get => GetProperty<List<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>>("sentinel_entity_mapping");
        set => this.WithProperty("sentinel_entity_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleScheduledTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelAlertRuleScheduledTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
