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
        set => SetProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public List<TerraformProperty<string>>? AllowedMethods
    {
        set => SetProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public List<TerraformProperty<string>>? AllowedOrigins
    {
        set => SetProperty("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public List<TerraformProperty<string>>? ExposedHeaders
    {
        set => SetProperty("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    public required TerraformProperty<double> MaxAgeInSeconds
    {
        set => SetProperty("max_age_in_seconds", value);
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
        set => SetProperty("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyDays
    {
        set => SetProperty("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformProperty<bool> Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyDays
    {
        set => SetProperty("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformProperty<bool> Write
    {
        set => SetProperty("write", value);
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
        set => SetProperty("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionPolicyDays
    {
        set => SetProperty("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        set => SetProperty("version", value);
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
        SetOutput("id");
        SetOutput("storage_account_id");
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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformProperty<string> StorageAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_account_id");
        set => SetProperty("storage_account_id", value);
    }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesCorsRuleBlock>? CorsRule
    {
        set => SetProperty("cors_rule", value);
    }

    /// <summary>
    /// Block for hour_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesHourMetricsBlock>? HourMetrics
    {
        set => SetProperty("hour_metrics", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesLoggingBlock>? Logging
    {
        set => SetProperty("logging", value);
    }

    /// <summary>
    /// Block for minute_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    public List<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>? MinuteMetrics
    {
        set => SetProperty("minute_metrics", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStorageAccountQueuePropertiesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
