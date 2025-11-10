using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for enabled_log in .
/// Nesting mode: set
/// </summary>
public class AzurermMonitorAadDiagnosticSettingEnabledLogBlock : ITerraformBlock
{
    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformPropertyName("category")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Category { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMonitorAadDiagnosticSettingTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_monitor_aad_diagnostic_setting resource.
/// </summary>
public class AzurermMonitorAadDiagnosticSetting : TerraformResource
{
    public AzurermMonitorAadDiagnosticSetting(string name) : base("azurerm_monitor_aad_diagnostic_setting", name)
    {
    }

    /// <summary>
    /// The eventhub_authorization_rule_id attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_authorization_rule_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventhubAuthorizationRuleId { get; set; }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [TerraformPropertyName("eventhub_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventhubName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("log_analytics_workspace_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LogAnalyticsWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageAccountId { get; set; }

    /// <summary>
    /// Block for enabled_log.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("enabled_log")]
    public TerraformSet<TerraformBlock<AzurermMonitorAadDiagnosticSettingEnabledLogBlock>>? EnabledLog { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMonitorAadDiagnosticSettingTimeoutsBlock>? Timeouts { get; set; } = new();

}
