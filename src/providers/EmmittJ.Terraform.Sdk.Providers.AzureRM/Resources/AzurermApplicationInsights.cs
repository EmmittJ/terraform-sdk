using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApplicationInsightsTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_application_insights resource.
/// </summary>
public partial class AzurermApplicationInsights : TerraformResource
{
    public AzurermApplicationInsights(string name) : base("azurerm_application_insights", name)
    {
    }

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationType is required")]
    [TerraformProperty("application_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationType { get; set; }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    [TerraformProperty("daily_data_cap_in_gb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DailyDataCapInGb { get; set; }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    [TerraformProperty("daily_data_cap_notifications_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DailyDataCapNotificationsDisabled { get; set; }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    [TerraformProperty("disable_ip_masking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableIpMasking { get; set; }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    [TerraformProperty("force_customer_storage_for_profiler")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceCustomerStorageForProfiler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_ingestion_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetIngestionEnabled { get; set; }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    [TerraformProperty("internet_query_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternetQueryEnabled { get; set; }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    [TerraformProperty("local_authentication_disabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthenticationDisabled { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    [TerraformProperty("retention_in_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionInDays { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformProperty("sampling_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SamplingPercentage { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> WorkspaceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermApplicationInsightsTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [TerraformProperty("app_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AppId { get; }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ConnectionString { get; }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformProperty("instrumentation_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstrumentationKey { get; }

}
