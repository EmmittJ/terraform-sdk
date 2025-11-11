using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for enabled_log in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMonitorAadDiagnosticSettingEnabledLogBlock : TerraformBlockBase
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformProperty("category")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Category { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMonitorAadDiagnosticSettingTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_monitor_aad_diagnostic_setting resource.
/// </summary>
public partial class AzurermMonitorAadDiagnosticSetting : TerraformResource
{
    public AzurermMonitorAadDiagnosticSetting(string name) : base("azurerm_monitor_aad_diagnostic_setting", name)
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    [TerraformProperty("eventhub_authorization_rule_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventhubAuthorizationRuleId { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformProperty("eventhub_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EventhubName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformProperty("log_analytics_workspace_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformProperty("storage_account_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageAccountId { get; set; }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("enabled_log")]
    public TerraformSet<TerraformBlock<AzurermMonitorAadDiagnosticSettingEnabledLogBlock>>? EnabledLog { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMonitorAadDiagnosticSettingTimeoutsBlock>? Timeouts { get; set; }

}
