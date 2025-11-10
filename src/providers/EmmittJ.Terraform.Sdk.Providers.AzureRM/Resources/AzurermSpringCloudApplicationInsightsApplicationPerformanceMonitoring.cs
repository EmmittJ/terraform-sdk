using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_application_insights_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_application_insights_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("connection_string");
        SetOutput("globally_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("role_instance");
        SetOutput("role_name");
        SetOutput("sampling_percentage");
        SetOutput("sampling_requests_per_second");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
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
    /// The role_instance attribute.
    /// </summary>
    public TerraformProperty<string> RoleInstance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_instance");
        set => SetProperty("role_instance", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string> RoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_name");
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double> SamplingPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sampling_percentage");
        set => SetProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The sampling_requests_per_second attribute.
    /// </summary>
    public TerraformProperty<double> SamplingRequestsPerSecond
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sampling_requests_per_second");
        set => SetProperty("sampling_requests_per_second", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudApplicationInsightsApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
