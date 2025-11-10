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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("api_token");
        SetOutput("api_url");
        SetOutput("connection_point");
        SetOutput("environment_id");
        SetOutput("globally_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("spring_cloud_service_id");
        SetOutput("tenant");
        SetOutput("tenant_token");
    }

    /// <summary>
    /// The api_token attribute.
    /// </summary>
    public TerraformProperty<string> ApiToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_token");
        set => SetProperty("api_token", value);
    }

    /// <summary>
    /// The api_url attribute.
    /// </summary>
    public TerraformProperty<string> ApiUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_url");
        set => SetProperty("api_url", value);
    }

    /// <summary>
    /// The connection_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionPoint is required")]
    public required TerraformProperty<string> ConnectionPoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_point");
        set => SetProperty("connection_point", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    public TerraformProperty<string> EnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_id");
        set => SetProperty("environment_id", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GloballyEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("globally_enabled");
        set => SetProperty("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_service_id");
        set => SetProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformProperty<string> Tenant
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant");
        set => SetProperty("tenant", value);
    }

    /// <summary>
    /// The tenant_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantToken is required")]
    public required TerraformProperty<string> TenantToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_token");
        set => SetProperty("tenant_token", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudDynatraceApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
