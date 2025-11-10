using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for log in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorTagRuleLogBlock : ITerraformBlock
{
    /// <summary>
    /// The aad_log_enabled attribute.
    /// </summary>
    [TerraformPropertyName("aad_log_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AadLogEnabled { get; set; }

    /// <summary>
    /// The resource_log_enabled attribute.
    /// </summary>
    [TerraformPropertyName("resource_log_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ResourceLogEnabled { get; set; }

    /// <summary>
    /// The subscription_log_enabled attribute.
    /// </summary>
    [TerraformPropertyName("subscription_log_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SubscriptionLogEnabled { get; set; }

}

/// <summary>
/// Block type for metric in .
/// Nesting mode: list
/// </summary>
public class AzurermDatadogMonitorTagRuleMetricBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatadogMonitorTagRuleTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_datadog_monitor_tag_rule resource.
/// </summary>
public class AzurermDatadogMonitorTagRule : TerraformResource
{
    public AzurermDatadogMonitorTagRule(string name) : base("azurerm_datadog_monitor_tag_rule", name)
    {
    }

    /// <summary>
    /// The datadog_monitor_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatadogMonitorId is required")]
    [TerraformPropertyName("datadog_monitor_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatadogMonitorId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// Block for log.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("log")]
    public TerraformList<TerraformBlock<AzurermDatadogMonitorTagRuleLogBlock>>? Log { get; set; } = new();

    /// <summary>
    /// Block for metric.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("metric")]
    public TerraformList<TerraformBlock<AzurermDatadogMonitorTagRuleMetricBlock>>? Metric { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatadogMonitorTagRuleTimeoutsBlock>? Timeouts { get; set; } = new();

}
