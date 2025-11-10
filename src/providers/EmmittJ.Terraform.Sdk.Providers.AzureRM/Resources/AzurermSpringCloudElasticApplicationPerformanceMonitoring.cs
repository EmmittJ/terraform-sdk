using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_elastic_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudElasticApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudElasticApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_elastic_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_packages");
        SetOutput("globally_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("server_url");
        SetOutput("service_name");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The application_packages attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationPackages is required")]
    public List<TerraformProperty<string>> ApplicationPackages
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("application_packages");
        set => SetProperty("application_packages", value);
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
    /// The server_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerUrl is required")]
    public required TerraformProperty<string> ServerUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("server_url");
        set => SetProperty("server_url", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformProperty<string> ServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_name");
        set => SetProperty("service_name", value);
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
    public AzurermSpringCloudElasticApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
