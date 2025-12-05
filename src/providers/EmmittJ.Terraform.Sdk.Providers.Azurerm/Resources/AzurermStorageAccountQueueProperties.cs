using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cors_rule in AzurermStorageAccountQueueProperties.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesCorsRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_rule";

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedHeaders is required")]
    public TerraformList<string>? AllowedHeaders
    {
        get => GetArgument<TerraformList<string>>("allowed_headers");
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    public TerraformList<string>? AllowedMethods
    {
        get => GetArgument<TerraformList<string>>("allowed_methods");
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    public TerraformList<string>? AllowedOrigins
    {
        get => GetArgument<TerraformList<string>>("allowed_origins");
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    public TerraformList<string>? ExposedHeaders
    {
        get => GetArgument<TerraformList<string>>("exposed_headers");
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    public required TerraformValue<double> MaxAgeInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}


/// <summary>
/// Block type for hour_metrics in AzurermStorageAccountQueueProperties.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesHourMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hour_metrics";

    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeApis
    {
        get => GetArgument<TerraformValue<bool>>("include_apis");
        set => SetArgument("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for logging in AzurermStorageAccountQueueProperties.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesLoggingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Delete is required")]
    public required TerraformValue<bool> Delete
    {
        get => GetRequiredArgument<TerraformValue<bool>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    public required TerraformValue<bool> Read
    {
        get => GetRequiredArgument<TerraformValue<bool>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    public required TerraformValue<bool> Write
    {
        get => GetRequiredArgument<TerraformValue<bool>>("write");
        set => SetArgument("write", value);
    }

}


/// <summary>
/// Block type for minute_metrics in AzurermStorageAccountQueueProperties.
/// Nesting mode: list
/// </summary>
public class AzurermStorageAccountQueuePropertiesMinuteMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "minute_metrics";

    /// <summary>
    /// The include_apis attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeApis
    {
        get => GetArgument<TerraformValue<bool>>("include_apis");
        set => SetArgument("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => GetArgument<TerraformValue<double>>("retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetRequiredArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageAccountQueueProperties.
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountQueuePropertiesTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_storage_account_queue_properties Terraform resource.
/// Manages a azurerm_storage_account_queue_properties resource.
/// </summary>
public partial class AzurermStorageAccountQueueProperties(string name) : TerraformResource("azurerm_storage_account_queue_properties", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// CorsRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesCorsRuleBlock>? CorsRule
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesCorsRuleBlock>>("cors_rule");
        set => SetArgument("cors_rule", value);
    }

    /// <summary>
    /// HourMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesHourMetricsBlock>? HourMetrics
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesHourMetricsBlock>>("hour_metrics");
        set => SetArgument("hour_metrics", value);
    }

    /// <summary>
    /// Logging block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesLoggingBlock>? Logging
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesLoggingBlock>>("logging");
        set => SetArgument("logging", value);
    }

    /// <summary>
    /// MinuteMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    public TerraformList<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>? MinuteMetrics
    {
        get => GetArgument<TerraformList<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock>>("minute_metrics");
        set => SetArgument("minute_metrics", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountQueuePropertiesTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountQueuePropertiesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
