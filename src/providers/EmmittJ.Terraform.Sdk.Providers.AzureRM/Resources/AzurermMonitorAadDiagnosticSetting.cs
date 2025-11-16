using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for enabled_log in .
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
        get => new TerraformReference<string>(this, "category");
        set => SetArgument("category", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "eventhub_authorization_rule_id");
        set => SetArgument("eventhub_authorization_rule_id", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubName
    {
        get => new TerraformReference<string>(this, "eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
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
