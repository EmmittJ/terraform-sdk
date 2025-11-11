using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountQueuePropertiesCorsRuleBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformProperty("allowed_headers")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformProperty("allowed_methods")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformProperty("allowed_origins")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    [TerraformProperty("exposed_headers")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ExposedHeaders { get; set; }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    [TerraformProperty("max_age_in_seconds")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MaxAgeInSeconds { get; set; }

}

/// <summary>
/// Block type for hour_metrics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountQueuePropertiesHourMetricsBlock : TerraformBlockBase
{
    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    [TerraformProperty("include_apis")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeApis { get; set; }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformProperty("retention_policy_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionPolicyDays { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountQueuePropertiesLoggingBlock : TerraformBlockBase
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    [TerraformProperty("delete")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    [TerraformProperty("read")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Read { get; set; }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformProperty("retention_policy_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionPolicyDays { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    [TerraformProperty("write")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Write { get; set; }

}

/// <summary>
/// Block type for minute_metrics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStorageAccountQueuePropertiesMinuteMetricsBlock : TerraformBlockBase
{
    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    [TerraformProperty("include_apis")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeApis { get; set; }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformProperty("retention_policy_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? RetentionPolicyDays { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageAccountQueuePropertiesTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_storage_account_queue_properties resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStorageAccountQueueProperties : TerraformResource
{
    public AzurermStorageAccountQueueProperties(string name) : base("azurerm_storage_account_queue_properties", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformProperty("storage_account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StorageAccountId { get; set; }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    [TerraformProperty("cors_rule")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesCorsRuleBlock>>? CorsRule { get; set; }

    /// <summary>
    /// Block for hour_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    [TerraformProperty("hour_metrics")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesHourMetricsBlock>>? HourMetrics { get; set; }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformProperty("logging")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesLoggingBlock>>? Logging { get; set; }

    /// <summary>
    /// Block for minute_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    [TerraformProperty("minute_metrics")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>>? MinuteMetrics { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStorageAccountQueuePropertiesTimeoutsBlock>? Timeouts { get; set; }

}
