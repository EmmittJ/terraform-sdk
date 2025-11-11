using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_spring_cloud_elastic_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudElasticApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudElasticApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_elastic_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The application_packages attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPackages is required")]
    [TerraformProperty("application_packages")]
    // Required argument - source generator will implement get/set
    public TerraformList<string>? ApplicationPackages { get; set; }

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
    /// The server_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerUrl is required")]
    [TerraformProperty("server_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServerUrl { get; set; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    [TerraformProperty("service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceName { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; }

}
