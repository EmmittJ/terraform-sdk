using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertV2ActionBlock() : TerraformBlock("action")
{
    /// <summary>
    /// The action_groups attribute.
    /// </summary>
    [TerraformProperty("action_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ActionGroups { get; set; }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    [TerraformProperty("custom_properties")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? CustomProperties { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock() : TerraformBlock("criteria")
{
    /// <summary>
    /// The metric_measure_column attribute.
    /// </summary>
    [TerraformProperty("metric_measure_column")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetricMeasureColumn { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformProperty("operator")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformProperty("query")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Query { get; set; }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    [TerraformProperty("resource_id_column")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ResourceIdColumn { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformProperty("threshold")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Threshold { get; set; }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    [TerraformProperty("time_aggregation_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeAggregationMethod { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_monitor_scheduled_query_rules_alert_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMonitorScheduledQueryRulesAlertV2 : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlertV2(string name) : base("azurerm_monitor_scheduled_query_rules_alert_v2", name)
    {
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_mitigation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoMitigationEnabled { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    [TerraformProperty("evaluation_frequency")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EvaluationFrequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    [TerraformProperty("mute_actions_after_alert_duration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MuteActionsAfterAlertDuration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    [TerraformProperty("query_time_range_override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? QueryTimeRangeOverride { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformProperty("scopes")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Scopes { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformProperty("severity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Severity { get; set; }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    [TerraformProperty("skip_query_validation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipQueryValidation { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    [TerraformProperty("target_resource_types")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? TargetResourceTypes { get; set; }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    [TerraformProperty("window_duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WindowDuration { get; set; }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    [TerraformProperty("workspace_alerts_storage_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WorkspaceAlertsStorageEnabled { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformProperty("action")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [TerraformProperty("criteria")]
    public required TerraformList<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock> Criteria { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_with_api_version attribute.
    /// </summary>
    [TerraformProperty("created_with_api_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedWithApiVersion { get; }

    /// <summary>
    /// The is_a_legacy_log_analytics_rule attribute.
    /// </summary>
    [TerraformProperty("is_a_legacy_log_analytics_rule")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsALegacyLogAnalyticsRule { get; }

    /// <summary>
    /// The is_workspace_alerts_storage_configured attribute.
    /// </summary>
    [TerraformProperty("is_workspace_alerts_storage_configured")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsWorkspaceAlertsStorageConfigured { get; }

}
