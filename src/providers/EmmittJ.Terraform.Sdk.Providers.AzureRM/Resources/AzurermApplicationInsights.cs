using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> ApplicationType { get; set; }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    [TerraformPropertyName("daily_data_cap_in_gb")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DailyDataCapInGb { get; set; }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    [TerraformPropertyName("daily_data_cap_notifications_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DailyDataCapNotificationsDisabled { get; set; }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    [TerraformPropertyName("disable_ip_masking")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableIpMasking { get; set; }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    [TerraformPropertyName("force_customer_storage_for_profiler")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceCustomerStorageForProfiler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_ingestion_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternetIngestionEnabled { get; set; }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internet_query_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternetQueryEnabled { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [TerraformPropertyName("local_authentication_disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LocalAuthenticationDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_in_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionInDays { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformPropertyName("sampling_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SamplingPercentage { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WorkspaceId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationInsightsTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [TerraformPropertyName("app_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app_id");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectionString => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_string");

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformPropertyName("instrumentation_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstrumentationKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instrumentation_key");

}
