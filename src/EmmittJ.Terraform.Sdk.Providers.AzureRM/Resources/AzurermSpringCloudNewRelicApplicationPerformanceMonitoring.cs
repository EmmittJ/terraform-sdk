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
    public bool? AgentEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("agent_enabled")?.Value;
        set => this.WithProperty("agent_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    public string? AppName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_name")?.Value;
        set => this.WithProperty("app_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    public double? AppServerPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("app_server_port")?.Value;
        set => this.WithProperty("app_server_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    public bool? AuditModeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("audit_mode_enabled")?.Value;
        set => this.WithProperty("audit_mode_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    public bool? AutoAppNamingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_app_naming_enabled")?.Value;
        set => this.WithProperty("auto_app_naming_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    public bool? AutoTransactionNamingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_transaction_naming_enabled")?.Value;
        set => this.WithProperty("auto_transaction_naming_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    public bool? CustomTracingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("custom_tracing_enabled")?.Value;
        set => this.WithProperty("custom_tracing_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public bool? GloballyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("globally_enabled")?.Value;
        set => this.WithProperty("globally_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    public string? LicenseKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_key")?.Value;
        set => this.WithProperty("license_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public string? SpringCloudServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_service_id")?.Value;
        set => this.WithProperty("spring_cloud_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
