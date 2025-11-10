using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_dynatrace_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudDynatraceApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_dynatrace_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_token attribute.
    /// </summary>
    public TerraformProperty<string>? ApiToken
    {
        get => GetProperty<TerraformProperty<string>>("api_token");
        set => this.WithProperty("api_token", value);
    }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    public TerraformProperty<string>? ApiUrl
    {
        get => GetProperty<TerraformProperty<string>>("api_url");
        set => this.WithProperty("api_url", value);
    }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPoint is required")]
    public required TerraformProperty<string> ConnectionPoint
    {
        get => GetProperty<TerraformProperty<string>>("connection_point");
        set => this.WithProperty("connection_point", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformProperty<string>? EnvironmentId
    {
        get => GetProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GloballyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("globally_enabled");
        set => this.WithProperty("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformProperty<string> Tenant
    {
        get => GetProperty<TerraformProperty<string>>("tenant");
        set => this.WithProperty("tenant", value);
    }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantToken is required")]
    public required TerraformProperty<string> TenantToken
    {
        get => GetProperty<TerraformProperty<string>>("tenant_token");
        set => this.WithProperty("tenant_token", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
