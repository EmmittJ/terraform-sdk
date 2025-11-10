using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cors_rule in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public List<TerraformProperty<string>>? AllowedHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_headers");
        set => WithProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public List<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public List<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public List<TerraformProperty<string>>? ExposedHeaders
    {
        get => GetProperty<List<TerraformProperty<string>>>("exposed_headers");
        set => WithProperty("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    public required TerraformProperty<double> MaxAgeInSeconds
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_age_in_seconds");
        set => WithProperty("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for hour_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesHourMetricsBlock : TerraformBlock
{
    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeApis
    {
        get => GetProperty<TerraformProperty<bool>>("include_apis");
        set => WithProperty("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_policy_days");
        set => WithProperty("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesLoggingBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformProperty<bool> Delete
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformProperty<bool> Read
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_policy_days");
        set => WithProperty("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformProperty<bool> Write
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("write");
        set => WithProperty("write", value);
    }

}

/// <summary>
/// Block type for minute_metrics in .
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesMinuteMetricsBlock : TerraformBlock
{
    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeApis
    {
        get => GetProperty<TerraformProperty<bool>>("include_apis");
        set => WithProperty("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_policy_days");
        set => WithProperty("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountQueuePropertiesTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_storage_account_queue_properties resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStorageAccountQueueProperties : TerraformResource
{
    public AzurermStorageAccountQueueProperties(string name) : base("azurerm_storage_account_queue_properties", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_account_id");
        set => this.WithProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesCorsRuleBlock>? CorsRule
    {
        get => GetProperty<List<AzurermStorageAccountQueuePropertiesCorsRuleBlock>>("cors_rule");
        set => this.WithProperty("cors_rule", value);
    }

    /// <summary>
    /// Block for hour_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesHourMetricsBlock>? HourMetrics
    {
        get => GetProperty<List<AzurermStorageAccountQueuePropertiesHourMetricsBlock>>("hour_metrics");
        set => this.WithProperty("hour_metrics", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesLoggingBlock>? Logging
    {
        get => GetProperty<List<AzurermStorageAccountQueuePropertiesLoggingBlock>>("logging");
        set => this.WithProperty("logging", value);
    }

    /// <summary>
    /// Block for minute_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>? MinuteMetrics
    {
        get => GetProperty<List<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>>("minute_metrics");
        set => this.WithProperty("minute_metrics", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountQueuePropertiesTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStorageAccountQueuePropertiesTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
