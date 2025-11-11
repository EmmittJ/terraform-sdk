using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_application_insights_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_application_insights_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformPropertyName("connection_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    [TerraformPropertyName("globally_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GloballyEnabled { get; set; }

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
    /// The role_instance attribute.
    /// </summary>
    [TerraformPropertyName("role_instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleInstance { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleName { get; set; }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    [TerraformPropertyName("sampling_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SamplingPercentage { get; set; }

    /// <summary>
    /// The sampling_requests_per_second attribute.
    /// </summary>
    [TerraformPropertyName("sampling_requests_per_second")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SamplingRequestsPerSecond { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformPropertyName("spring_cloud_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; }

}
