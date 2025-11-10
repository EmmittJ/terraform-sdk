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
        set => SetProperty("description_format", value);
    }

    /// <summary>
    /// The display_name_format attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayNameFormat
    {
        set => SetProperty("display_name_format", value);
    }

    /// <summary>
    /// The severity_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? SeverityColumnName
    {
        set => SetProperty("severity_column_name", value);
    }

    /// <summary>
    /// The tactics_column_name attribute.
    /// </summary>
    public TerraformProperty<string>? TacticsColumnName
    {
        set => SetProperty("tactics_column_name", value);
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
        set => SetProperty("entity_type", value);
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
        set => SetProperty("aggregation_method", value);
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
        set => SetProperty("create_incident_enabled", value);
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
        set => SetProperty("column_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_sentinel_alert_rule_scheduled resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSentinelAlertRuleScheduled : TerraformResource
{
    public AzurermSentinelAlertRuleScheduled(string name) : base("azurerm_sentinel_alert_rule_scheduled", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alert_rule_template_guid");
        SetOutput("alert_rule_template_version");
        SetOutput("custom_details");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("query");
        SetOutput("query_frequency");
        SetOutput("query_period");
        SetOutput("severity");
        SetOutput("suppression_duration");
        SetOutput("suppression_enabled");
        SetOutput("tactics");
        SetOutput("techniques");
        SetOutput("trigger_operator");
        SetOutput("trigger_threshold");
    }

    /// <summary>
    /// The alert_rule_template_guid attribute.
    /// </summary>
    public TerraformProperty<string> AlertRuleTemplateGuid
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alert_rule_template_guid");
        set => SetProperty("alert_rule_template_guid", value);
    }

    /// <summary>
    /// The alert_rule_template_version attribute.
    /// </summary>
    public TerraformProperty<string> AlertRuleTemplateVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alert_rule_template_version");
        set => SetProperty("alert_rule_template_version", value);
    }

    /// <summary>
    /// The custom_details attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> CustomDetails
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("custom_details");
        set => SetProperty("custom_details", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformProperty<string> Query
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query");
        set => SetProperty("query", value);
    }

    /// <summary>
    /// The query_frequency attribute.
    /// </summary>
    public TerraformProperty<string> QueryFrequency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_frequency");
        set => SetProperty("query_frequency", value);
    }

    /// <summary>
    /// The query_period attribute.
    /// </summary>
    public TerraformProperty<string> QueryPeriod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_period");
        set => SetProperty("query_period", value);
    }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformProperty<string> Severity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("severity");
        set => SetProperty("severity", value);
    }

    /// <summary>
    /// The suppression_duration attribute.
    /// </summary>
    public TerraformProperty<string> SuppressionDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("suppression_duration");
        set => SetProperty("suppression_duration", value);
    }

    /// <summary>
    /// The suppression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SuppressionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("suppression_enabled");
        set => SetProperty("suppression_enabled", value);
    }

    /// <summary>
    /// The tactics attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Tactics
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("tactics");
        set => SetProperty("tactics", value);
    }

    /// <summary>
    /// The techniques attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Techniques
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("techniques");
        set => SetProperty("techniques", value);
    }

    /// <summary>
    /// The trigger_operator attribute.
    /// </summary>
    public TerraformProperty<string> TriggerOperator
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trigger_operator");
        set => SetProperty("trigger_operator", value);
    }

    /// <summary>
    /// The trigger_threshold attribute.
    /// </summary>
    public TerraformProperty<double> TriggerThreshold
    {
        get => GetRequiredOutput<TerraformProperty<double>>("trigger_threshold");
        set => SetProperty("trigger_threshold", value);
    }

    /// <summary>
    /// Block for alert_details_override.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSentinelAlertRuleScheduledAlertDetailsOverrideBlock>? AlertDetailsOverride
    {
        set => SetProperty("alert_details_override", value);
    }

    /// <summary>
    /// Block for entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 EntityMapping block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledEntityMappingBlock>? EntityMapping
    {
        set => SetProperty("entity_mapping", value);
    }

    /// <summary>
    /// Block for event_grouping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventGrouping block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledEventGroupingBlock>? EventGrouping
    {
        set => SetProperty("event_grouping", value);
    }

    /// <summary>
    /// Block for incident.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Incident block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledIncidentBlock>? Incident
    {
        set => SetProperty("incident", value);
    }

    /// <summary>
    /// Block for sentinel_entity_mapping.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 SentinelEntityMapping block(s) allowed")]
    public List<AzurermSentinelAlertRuleScheduledSentinelEntityMappingBlock>? SentinelEntityMapping
    {
        set => SetProperty("sentinel_entity_mapping", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelAlertRuleScheduledTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
