using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_spring_cloud_app_dynamics_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_app_dynamics_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The agent_account_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountAccessKey is required")]
    [TerraformPropertyName("agent_account_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentAccountAccessKey { get; set; }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountName is required")]
    [TerraformPropertyName("agent_account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentAccountName { get; set; }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    [TerraformPropertyName("agent_application_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AgentApplicationName { get; set; }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    [TerraformPropertyName("agent_node_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AgentNodeName { get; set; }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    [TerraformPropertyName("agent_tier_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AgentTierName { get; set; }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    [TerraformPropertyName("agent_unique_host_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AgentUniqueHostId { get; set; }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControllerHostName is required")]
    [TerraformPropertyName("controller_host_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ControllerHostName { get; set; }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    [TerraformPropertyName("controller_port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ControllerPort { get; set; }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    [TerraformPropertyName("controller_ssl_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ControllerSslEnabled { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock>? Timeouts { get; set; } = new();

}
