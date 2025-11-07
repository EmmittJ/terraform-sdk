using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The agent_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AgentEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("agent_enabled");
        set => this.WithProperty("agent_enabled", value);
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AppName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_name");
        set => this.WithProperty("app_name", value);
    }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AppServerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("app_server_port");
        set => this.WithProperty("app_server_port", value);
    }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AuditModeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("audit_mode_enabled");
        set => this.WithProperty("audit_mode_enabled", value);
    }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoAppNamingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_app_naming_enabled");
        set => this.WithProperty("auto_app_naming_enabled", value);
    }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoTransactionNamingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_transaction_naming_enabled");
        set => this.WithProperty("auto_transaction_naming_enabled", value);
    }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CustomTracingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("custom_tracing_enabled");
        set => this.WithProperty("custom_tracing_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GloballyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("globally_enabled");
        set => this.WithProperty("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LicenseKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_key");
        set => this.WithProperty("license_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

}
