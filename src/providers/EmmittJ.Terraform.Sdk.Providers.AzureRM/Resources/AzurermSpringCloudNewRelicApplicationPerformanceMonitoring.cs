using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_spring_cloud_new_relic_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudNewRelicApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_new_relic_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The agent_enabled attribute.
    /// </summary>
    [TerraformProperty("agent_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AgentEnabled { get; set; }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformProperty("app_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppName { get; set; }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    [TerraformProperty("app_server_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AppServerPort { get; set; }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    [TerraformProperty("audit_mode_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AuditModeEnabled { get; set; }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_app_naming_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoAppNamingEnabled { get; set; }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_transaction_naming_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoTransactionNamingEnabled { get; set; }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    [TerraformProperty("custom_tracing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomTracingEnabled { get; set; }

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
    /// The labels attribute.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseKey is required")]
    [TerraformProperty("license_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LicenseKey { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    public partial TerraformBlock<AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; }

}
