using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceMonitorDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_dynatrace_monitor.
/// </summary>
public class AzurermDynatraceMonitorDataSource : TerraformDataSource
{
    public AzurermDynatraceMonitorDataSource(string name) : base("azurerm_dynatrace_monitor", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDynatraceMonitorDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The environment_properties attribute.
    /// </summary>
    [TerraformPropertyName("environment_properties")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EnvironmentProperties => new TerraformReference(this, "environment_properties");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    [TerraformPropertyName("marketplace_subscription")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MarketplaceSubscription => new TerraformReference(this, "marketplace_subscription");

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MonitoringEnabled => new TerraformReference(this, "monitoring_enabled");

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformPropertyName("plan")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Plan => new TerraformReference(this, "plan");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Output-only attribute - read-only reference
    public TerraformList<object> User => new TerraformReference(this, "user");

}
