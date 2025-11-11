using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2ActionBlock
{
    /// <summary>
    /// The action_groups attribute.
    /// </summary>
    [TerraformPropertyName("action_groups")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ActionGroups { get; set; }

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    [TerraformPropertyName("custom_properties")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? CustomProperties { get; set; }

}

/// <summary>
/// Block type for criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock
{
    /// <summary>
    /// The metric_measure_column attribute.
    /// </summary>
    [TerraformPropertyName("metric_measure_column")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MetricMeasureColumn { get; set; }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Operator is required")]
    [TerraformPropertyName("operator")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Operator { get; set; }

    /// <summary>
    /// The query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    [TerraformPropertyName("query")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Query { get; set; }

    /// <summary>
    /// The resource_id_column attribute.
    /// </summary>
    [TerraformPropertyName("resource_id_column")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceIdColumn { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Threshold is required")]
    [TerraformPropertyName("threshold")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Threshold { get; set; }

    /// <summary>
    /// The time_aggregation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeAggregationMethod is required")]
    [TerraformPropertyName("time_aggregation_method")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeAggregationMethod { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock
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
/// Manages a azurerm_monitor_scheduled_query_rules_alert_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMonitorScheduledQueryRulesAlertV2 : TerraformResource
{
    public AzurermMonitorScheduledQueryRulesAlertV2(string name) : base("azurerm_monitor_scheduled_query_rules_alert_v2", name)
    {
    }

    /// <summary>
    /// The auto_mitigation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_mitigation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoMitigationEnabled { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The evaluation_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EvaluationFrequency is required")]
    [TerraformPropertyName("evaluation_frequency")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EvaluationFrequency { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The mute_actions_after_alert_duration attribute.
    /// </summary>
    [TerraformPropertyName("mute_actions_after_alert_duration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MuteActionsAfterAlertDuration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_time_range_override attribute.
    /// </summary>
    [TerraformPropertyName("query_time_range_override")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? QueryTimeRangeOverride { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The scopes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scopes is required")]
    [TerraformPropertyName("scopes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Scopes { get; set; }

    /// <summary>
    /// The severity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformPropertyName("severity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Severity { get; set; }

    /// <summary>
    /// The skip_query_validation attribute.
    /// </summary>
    [TerraformPropertyName("skip_query_validation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipQueryValidation { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The target_resource_types attribute.
    /// </summary>
    [TerraformPropertyName("target_resource_types")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? TargetResourceTypes { get; set; }

    /// <summary>
    /// The window_duration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowDuration is required")]
    [TerraformPropertyName("window_duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WindowDuration { get; set; }

    /// <summary>
    /// The workspace_alerts_storage_enabled attribute.
    /// </summary>
    [TerraformPropertyName("workspace_alerts_storage_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WorkspaceAlertsStorageEnabled { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformPropertyName("action")]
    public TerraformList<TerraformBlock<AzurermMonitorScheduledQueryRulesAlertV2ActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Criteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Criteria block(s) required")]
    [TerraformPropertyName("criteria")]
    public TerraformList<TerraformBlock<AzurermMonitorScheduledQueryRulesAlertV2CriteriaBlock>>? Criteria { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermMonitorScheduledQueryRulesAlertV2IdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorScheduledQueryRulesAlertV2TimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The created_with_api_version attribute.
    /// </summary>
    [TerraformPropertyName("created_with_api_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedWithApiVersion => new TerraformReference(this, "created_with_api_version");

    /// <summary>
    /// The is_a_legacy_log_analytics_rule attribute.
    /// </summary>
    [TerraformPropertyName("is_a_legacy_log_analytics_rule")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsALegacyLogAnalyticsRule => new TerraformReference(this, "is_a_legacy_log_analytics_rule");

    /// <summary>
    /// The is_workspace_alerts_storage_configured attribute.
    /// </summary>
    [TerraformPropertyName("is_workspace_alerts_storage_configured")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsWorkspaceAlertsStorageConfigured => new TerraformReference(this, "is_workspace_alerts_storage_configured");

}
