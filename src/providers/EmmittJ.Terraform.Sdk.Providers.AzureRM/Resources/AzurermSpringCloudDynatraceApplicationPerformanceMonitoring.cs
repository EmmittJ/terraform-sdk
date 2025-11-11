using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_spring_cloud_dynatrace_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudDynatraceApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_dynatrace_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The api_token attribute.
    /// </summary>
    [TerraformProperty("api_token")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiToken { get; set; }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    [TerraformProperty("api_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ApiUrl { get; set; }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPoint is required")]
    [TerraformProperty("connection_point")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConnectionPoint { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [TerraformProperty("environment_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnvironmentId { get; set; }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    [TerraformProperty("globally_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? GloballyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformProperty("tenant")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Tenant { get; set; }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantToken is required")]
    [TerraformProperty("tenant_token")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TenantToken { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; }

}
