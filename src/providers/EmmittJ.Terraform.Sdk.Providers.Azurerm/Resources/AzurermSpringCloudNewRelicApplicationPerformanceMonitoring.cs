using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudNewRelicApplicationPerformanceMonitoring.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_new_relic_application_performance_monitoring Terraform resource.
/// Manages a azurerm_spring_cloud_new_relic_application_performance_monitoring resource.
/// </summary>
public partial class AzurermSpringCloudNewRelicApplicationPerformanceMonitoring(string name) : TerraformResource("azurerm_spring_cloud_new_relic_application_performance_monitoring", name)
{
    /// <summary>
    /// The agent_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AgentEnabled
    {
        get => GetArgument<TerraformValue<bool>>("agent_enabled");
        set => SetArgument("agent_enabled", value);
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformValue<string> AppName
    {
        get => GetArgument<TerraformValue<string>>("app_name");
        set => SetArgument("app_name", value);
    }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    public TerraformValue<double>? AppServerPort
    {
        get => GetArgument<TerraformValue<double>>("app_server_port");
        set => SetArgument("app_server_port", value);
    }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AuditModeEnabled
    {
        get => GetArgument<TerraformValue<bool>>("audit_mode_enabled");
        set => SetArgument("audit_mode_enabled", value);
    }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoAppNamingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_app_naming_enabled");
        set => SetArgument("auto_app_naming_enabled", value);
    }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoTransactionNamingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_transaction_naming_enabled");
        set => SetArgument("auto_transaction_naming_enabled", value);
    }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomTracingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("custom_tracing_enabled");
        set => SetArgument("custom_tracing_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GloballyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("globally_enabled");
        set => SetArgument("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseKey is required")]
    public required TerraformValue<string> LicenseKey
    {
        get => GetArgument<TerraformValue<string>>("license_key");
        set => SetArgument("license_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_service_id");
        set => SetArgument("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
