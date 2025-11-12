using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_spring_cloud_app_dynamics_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_app_dynamics_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The agent_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountAccessKey is required")]
    [TerraformProperty("agent_account_access_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentAccountAccessKey { get; set; }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountName is required")]
    [TerraformProperty("agent_account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AgentAccountName { get; set; }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    [TerraformProperty("agent_application_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgentApplicationName { get; set; }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    [TerraformProperty("agent_node_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgentNodeName { get; set; }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    [TerraformProperty("agent_tier_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgentTierName { get; set; }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    [TerraformProperty("agent_unique_host_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgentUniqueHostId { get; set; }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControllerHostName is required")]
    [TerraformProperty("controller_host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ControllerHostName { get; set; }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    [TerraformProperty("controller_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ControllerPort { get; set; }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    [TerraformProperty("controller_ssl_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ControllerSslEnabled { get; set; }

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
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock Timeouts { get; set; } = new();

}
