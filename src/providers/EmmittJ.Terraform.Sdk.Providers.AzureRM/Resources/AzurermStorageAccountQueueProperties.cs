using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for cors_rule in .
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
    [TerraformArgument("allowed_headers")]
    public TerraformList<string>? AllowedHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedMethods is required")]
    [TerraformArgument("allowed_methods")]
    public TerraformList<string>? AllowedMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOrigins is required")]
    [TerraformArgument("allowed_origins")]
    public TerraformList<string>? AllowedOrigins
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The exposed_headers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExposedHeaders is required")]
    [TerraformArgument("exposed_headers")]
    public TerraformList<string>? ExposedHeaders
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "exposed_headers").ResolveNodes(ctx));
        set => SetArgument("exposed_headers", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxAgeInSeconds is required")]
    [TerraformArgument("max_age_in_seconds")]
    public required TerraformValue<double> MaxAgeInSeconds
    {
        get => new TerraformReference<double>(this, "max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for hour_metrics in .
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
    [TerraformArgument("include_apis")]
    public TerraformValue<bool>? IncludeApis
    {
        get => new TerraformReference<bool>(this, "include_apis");
        set => SetArgument("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformArgument("retention_policy_days")]
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => new TerraformReference<double>(this, "retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for logging in .
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
    [TerraformArgument("delete")]
    public required TerraformValue<bool> Delete
    {
        get => new TerraformReference<bool>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Read is required")]
    [TerraformArgument("read")]
    public required TerraformValue<bool> Read
    {
        get => new TerraformReference<bool>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformArgument("retention_policy_days")]
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => new TerraformReference<double>(this, "retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The write attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Write is required")]
    [TerraformArgument("write")]
    public required TerraformValue<bool> Write
    {
        get => new TerraformReference<bool>(this, "write");
        set => SetArgument("write", value);
    }

}

/// <summary>
/// Block type for minute_metrics in .
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
    [TerraformArgument("include_apis")]
    public TerraformValue<bool>? IncludeApis
    {
        get => new TerraformReference<bool>(this, "include_apis");
        set => SetArgument("include_apis", value);
    }

    /// <summary>
    /// The retention_policy_days attribute.
    /// </summary>
    [TerraformArgument("retention_policy_days")]
    public TerraformValue<double>? RetentionPolicyDays
    {
        get => new TerraformReference<double>(this, "retention_policy_days");
        set => SetArgument("retention_policy_days", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    [TerraformArgument("storage_account_id")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Block for cors_rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 CorsRule block(s) allowed")]
    [TerraformArgument("cors_rule")]
    public TerraformList<AzurermStorageAccountQueuePropertiesCorsRuleBlock> CorsRule { get; set; } = new();

    /// <summary>
    /// Block for hour_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HourMetrics block(s) allowed")]
    [TerraformArgument("hour_metrics")]
    public TerraformList<AzurermStorageAccountQueuePropertiesHourMetricsBlock> HourMetrics { get; set; } = new();

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    [TerraformArgument("logging")]
    public TerraformList<AzurermStorageAccountQueuePropertiesLoggingBlock> Logging { get; set; } = new();

    /// <summary>
    /// Block for minute_metrics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MinuteMetrics block(s) allowed")]
    [TerraformArgument("minute_metrics")]
    public TerraformList<AzurermStorageAccountQueuePropertiesMinuteMetricsBlock> MinuteMetrics { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageAccountQueuePropertiesTimeoutsBlock Timeouts { get; set; } = new();

}
