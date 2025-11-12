using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_application_insights_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_application_insights_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    [TerraformProperty("globally_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GloballyEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The role_instance attribute.
    /// </summary>
    [TerraformProperty("role_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleInstance { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformProperty("role_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleName { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformProperty("sampling_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SamplingPercentage { get; set; }

    /// <summary>
    /// The sampling_requests_per_second attribute.
    /// </summary>
    [TerraformProperty("sampling_requests_per_second")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SamplingRequestsPerSecond { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock Timeouts { get; set; } = new();

}
