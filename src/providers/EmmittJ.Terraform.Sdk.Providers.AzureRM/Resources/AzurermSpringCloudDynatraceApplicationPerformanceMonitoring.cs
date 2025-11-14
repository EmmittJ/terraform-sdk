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
public class AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("api_token")]
    public TerraformValue<string>? ApiToken
    {
        get => new TerraformReference<string>(this, "api_token");
        set => SetArgument("api_token", value);
    }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    [TerraformArgument("api_url")]
    public TerraformValue<string>? ApiUrl
    {
        get => new TerraformReference<string>(this, "api_url");
        set => SetArgument("api_url", value);
    }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPoint is required")]
    [TerraformArgument("connection_point")]
    public required TerraformValue<string> ConnectionPoint
    {
        get => new TerraformReference<string>(this, "connection_point");
        set => SetArgument("connection_point", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [TerraformArgument("environment_id")]
    public TerraformValue<string>? EnvironmentId
    {
        get => new TerraformReference<string>(this, "environment_id");
        set => SetArgument("environment_id", value);
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
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    [TerraformArgument("tenant")]
    public required TerraformValue<string> Tenant
    {
        get => new TerraformReference<string>(this, "tenant");
        set => SetArgument("tenant", value);
    }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantToken is required")]
    [TerraformArgument("tenant_token")]
    public required TerraformValue<string> TenantToken
    {
        get => new TerraformReference<string>(this, "tenant_token");
        set => SetArgument("tenant_token", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock Timeouts { get; set; } = new();

}
