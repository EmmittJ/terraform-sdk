using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("agent_account_access_key")]
    public required TerraformValue<string> AgentAccountAccessKey
    {
        get => new TerraformReference<string>(this, "agent_account_access_key");
        set => SetArgument("agent_account_access_key", value);
    }

    /// <summary>
    /// The agent_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentAccountName is required")]
    [TerraformArgument("agent_account_name")]
    public required TerraformValue<string> AgentAccountName
    {
        get => new TerraformReference<string>(this, "agent_account_name");
        set => SetArgument("agent_account_name", value);
    }

    /// <summary>
    /// The agent_application_name attribute.
    /// </summary>
    [TerraformArgument("agent_application_name")]
    public TerraformValue<string>? AgentApplicationName
    {
        get => new TerraformReference<string>(this, "agent_application_name");
        set => SetArgument("agent_application_name", value);
    }

    /// <summary>
    /// The agent_node_name attribute.
    /// </summary>
    [TerraformArgument("agent_node_name")]
    public TerraformValue<string>? AgentNodeName
    {
        get => new TerraformReference<string>(this, "agent_node_name");
        set => SetArgument("agent_node_name", value);
    }

    /// <summary>
    /// The agent_tier_name attribute.
    /// </summary>
    [TerraformArgument("agent_tier_name")]
    public TerraformValue<string>? AgentTierName
    {
        get => new TerraformReference<string>(this, "agent_tier_name");
        set => SetArgument("agent_tier_name", value);
    }

    /// <summary>
    /// The agent_unique_host_id attribute.
    /// </summary>
    [TerraformArgument("agent_unique_host_id")]
    public TerraformValue<string>? AgentUniqueHostId
    {
        get => new TerraformReference<string>(this, "agent_unique_host_id");
        set => SetArgument("agent_unique_host_id", value);
    }

    /// <summary>
    /// The controller_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ControllerHostName is required")]
    [TerraformArgument("controller_host_name")]
    public required TerraformValue<string> ControllerHostName
    {
        get => new TerraformReference<string>(this, "controller_host_name");
        set => SetArgument("controller_host_name", value);
    }

    /// <summary>
    /// The controller_port attribute.
    /// </summary>
    [TerraformArgument("controller_port")]
    public TerraformValue<double>? ControllerPort
    {
        get => new TerraformReference<double>(this, "controller_port");
        set => SetArgument("controller_port", value);
    }

    /// <summary>
    /// The controller_ssl_enabled attribute.
    /// </summary>
    [TerraformArgument("controller_ssl_enabled")]
    public TerraformValue<bool>? ControllerSslEnabled
    {
        get => new TerraformReference<bool>(this, "controller_ssl_enabled");
        set => SetArgument("controller_ssl_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    [TerraformArgument("globally_enabled")]
    public TerraformValue<bool>? GloballyEnabled
    {
        get => new TerraformReference<bool>(this, "globally_enabled");
        set => SetArgument("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformArgument("spring_cloud_service_id")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => new TerraformReference<string>(this, "spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudAppDynamicsApplicationPerformanceMonitoringTimeoutsBlock Timeouts { get; set; } = new();

}
