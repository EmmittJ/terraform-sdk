using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_spring_cloud_dynatrace_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudDynatraceApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_dynatrace_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The api_token attribute.
    /// </summary>
    [TerraformPropertyName("api_token")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiToken { get; set; }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    [TerraformPropertyName("api_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApiUrl { get; set; }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPoint is required")]
    [TerraformPropertyName("connection_point")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConnectionPoint { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [TerraformPropertyName("environment_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnvironmentId { get; set; }

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
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformPropertyName("tenant")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Tenant { get; set; }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantToken is required")]
    [TerraformPropertyName("tenant_token")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TenantToken { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; } = new();

}
