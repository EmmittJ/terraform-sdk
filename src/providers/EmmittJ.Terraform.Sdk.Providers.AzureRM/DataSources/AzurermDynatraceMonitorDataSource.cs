using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDynatraceMonitorDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDynatraceMonitorDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The environment_properties attribute.
    /// </summary>
    [TerraformPropertyName("environment_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EnvironmentProperties => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "environment_properties");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The marketplace_subscription attribute.
    /// </summary>
    [TerraformPropertyName("marketplace_subscription")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MarketplaceSubscription => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "marketplace_subscription");

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MonitoringEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "monitoring_enabled");

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [TerraformPropertyName("plan")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Plan => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "plan");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> User => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user");

}
