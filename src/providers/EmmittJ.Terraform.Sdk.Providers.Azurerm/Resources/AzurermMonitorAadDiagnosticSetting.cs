using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for enabled_log in AzurermMonitorAadDiagnosticSetting.
/// Nesting mode: set
/// </summary>
public class AzurermMonitorAadDiagnosticSettingEnabledLogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enabled_log";

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => GetRequiredArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// RetentionPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RetentionPolicy block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermMonitorAadDiagnosticSettingEnabledLogBlockRetentionPolicyBlock>? RetentionPolicy
    {
        get => GetArgument<TerraformList<AzurermMonitorAadDiagnosticSettingEnabledLogBlockRetentionPolicyBlock>>("retention_policy");
        set => SetArgument("retention_policy", value);
    }

}

/// <summary>
/// Block type for retention_policy in AzurermMonitorAadDiagnosticSettingEnabledLogBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermMonitorAadDiagnosticSettingEnabledLogBlockRetentionPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "retention_policy";

    /// <summary>
    /// The days attribute.
    /// </summary>
    public TerraformValue<double>? Days
    {
        get => GetArgument<TerraformValue<double>>("days");
        set => SetArgument("days", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMonitorAadDiagnosticSetting.
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAadDiagnosticSettingTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_monitor_aad_diagnostic_setting Terraform resource.
/// Manages a azurerm_monitor_aad_diagnostic_setting resource.
/// </summary>
public partial class AzurermMonitorAadDiagnosticSetting(string name) : TerraformResource("azurerm_monitor_aad_diagnostic_setting", name)
{
    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    public TerraformValue<string>? EventhubAuthorizationRuleId
    {
        get => GetArgument<TerraformValue<string>>("eventhub_authorization_rule_id");
        set => SetArgument("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// EnabledLog block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermMonitorAadDiagnosticSettingEnabledLogBlock>? EnabledLog
    {
        get => GetArgument<TerraformSet<AzurermMonitorAadDiagnosticSettingEnabledLogBlock>>("enabled_log");
        set => SetArgument("enabled_log", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMonitorAadDiagnosticSettingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMonitorAadDiagnosticSettingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
