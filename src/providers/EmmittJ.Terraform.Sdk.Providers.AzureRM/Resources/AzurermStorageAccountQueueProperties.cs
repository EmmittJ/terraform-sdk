using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesCorsRuleBlock : ITerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    [TerraformPropertyName("allowed_headers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedHeaders { get; set; }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformPropertyName("allowed_methods")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedMethods { get; set; }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformPropertyName("allowed_origins")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedOrigins { get; set; }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    [TerraformPropertyName("exposed_headers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? ExposedHeaders { get; set; }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    [TerraformPropertyName("max_age_in_seconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxAgeInSeconds { get; set; }

}

/// <summary>
/// Block type for hour_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesHourMetricsBlock : ITerraformBlock
{
    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    [TerraformPropertyName("include_apis")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeApis { get; set; }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_policy_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionPolicyDays { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesLoggingBlock : ITerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    [TerraformPropertyName("delete")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    [TerraformPropertyName("read")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Read { get; set; }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_policy_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionPolicyDays { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    [TerraformPropertyName("write")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Write { get; set; }

}

/// <summary>
/// Block type for minute_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesMinuteMetricsBlock : ITerraformBlock
{
    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    [TerraformPropertyName("include_apis")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludeApis { get; set; }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_policy_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionPolicyDays { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountQueuePropertiesTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_storage_account_queue_properties resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStorageAccountQueueProperties : TerraformResource
{
    public AzurermStorageAccountQueueProperties(string name) : base("azurerm_storage_account_queue_properties", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformPropertyName("storage_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StorageAccountId { get; set; }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    [TerraformPropertyName("cors_rule")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesCorsRuleBlock>>? CorsRule { get; set; } = new();

    /// <summary>
    /// Block for hour_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    [TerraformPropertyName("hour_metrics")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesHourMetricsBlock>>? HourMetrics { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformPropertyName("logging")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesLoggingBlock>>? Logging { get; set; } = new();

    /// <summary>
    /// Block for minute_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    [TerraformPropertyName("minute_metrics")]
    public TerraformList<TerraformBlock<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>>? MinuteMetrics { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStorageAccountQueuePropertiesTimeoutsBlock>? Timeouts { get; set; } = new();

}
