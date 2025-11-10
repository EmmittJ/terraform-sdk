using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_spring_cloud_new_relic_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_new_relic_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The agent_enabled attribute.
    /// </summary>
    [TerraformPropertyName("agent_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AgentEnabled { get; set; }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformPropertyName("app_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppName { get; set; }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    [TerraformPropertyName("app_server_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? AppServerPort { get; set; }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    [TerraformPropertyName("audit_mode_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AuditModeEnabled { get; set; }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_app_naming_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoAppNamingEnabled { get; set; }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_transaction_naming_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoTransactionNamingEnabled { get; set; }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    [TerraformPropertyName("custom_tracing_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomTracingEnabled { get; set; }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    [TerraformPropertyName("globally_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GloballyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The labels attribute.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseKey is required")]
    [TerraformPropertyName("license_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseKey { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformPropertyName("spring_cloud_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; } = new();

}
