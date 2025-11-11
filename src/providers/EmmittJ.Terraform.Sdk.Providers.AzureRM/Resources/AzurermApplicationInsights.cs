using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsTimeoutsBlock
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
/// Manages a azurerm_application_insights resource.
/// </summary>
public class AzurermApplicationInsights : TerraformResource
{
    public AzurermApplicationInsights(string name) : base("azurerm_application_insights", name)
    {
    }

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationType is required")]
    [TerraformPropertyName("application_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationType { get; set; }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("daily_data_cap_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DailyDataCapInGb { get; set; }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    [TerraformPropertyName("daily_data_cap_notifications_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DailyDataCapNotificationsDisabled { get; set; }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    [TerraformPropertyName("disable_ip_masking")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableIpMasking { get; set; }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    [TerraformPropertyName("force_customer_storage_for_profiler")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceCustomerStorageForProfiler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_ingestion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternetIngestionEnabled { get; set; }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_query_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternetQueryEnabled { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? LocalAuthenticationDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetentionInDays { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformPropertyName("sampling_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SamplingPercentage { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> WorkspaceId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationInsightsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AppId => new TerraformReference(this, "app_id");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConnectionString => new TerraformReference(this, "connection_string");

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformPropertyName("instrumentation_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstrumentationKey => new TerraformReference(this, "instrumentation_key");

}
