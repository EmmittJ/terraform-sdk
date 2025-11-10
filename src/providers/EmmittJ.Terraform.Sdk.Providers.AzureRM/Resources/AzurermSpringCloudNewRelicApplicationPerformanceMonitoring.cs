using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_new_relic_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_new_relic_application_performance_monitoring", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("agent_enabled");
        SetOutput("app_name");
        SetOutput("app_server_port");
        SetOutput("audit_mode_enabled");
        SetOutput("auto_app_naming_enabled");
        SetOutput("auto_transaction_naming_enabled");
        SetOutput("custom_tracing_enabled");
        SetOutput("globally_enabled");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("license_key");
        SetOutput("name");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The agent_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AgentEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("agent_enabled");
        set => SetProperty("agent_enabled", value);
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformProperty<string> AppName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_name");
        set => SetProperty("app_name", value);
    }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    public TerraformProperty<double> AppServerPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("app_server_port");
        set => SetProperty("app_server_port", value);
    }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AuditModeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("audit_mode_enabled");
        set => SetProperty("audit_mode_enabled", value);
    }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoAppNamingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_app_naming_enabled");
        set => SetProperty("auto_app_naming_enabled", value);
    }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoTransactionNamingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_transaction_naming_enabled");
        set => SetProperty("auto_transaction_naming_enabled", value);
    }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CustomTracingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("custom_tracing_enabled");
        set => SetProperty("custom_tracing_enabled", value);
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
    /// The labels attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseKey is required")]
    public required TerraformProperty<string> LicenseKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_key");
        set => SetProperty("license_key", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
