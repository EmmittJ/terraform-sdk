using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "agent_enabled");
        set => SetArgument("agent_enabled", value);
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformValue<string> AppName
    {
        get => new TerraformReference<string>(this, "app_name");
        set => SetArgument("app_name", value);
    }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    public TerraformValue<double>? AppServerPort
    {
        get => new TerraformReference<double>(this, "app_server_port");
        set => SetArgument("app_server_port", value);
    }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AuditModeEnabled
    {
        get => new TerraformReference<bool>(this, "audit_mode_enabled");
        set => SetArgument("audit_mode_enabled", value);
    }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoAppNamingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_app_naming_enabled");
        set => SetArgument("auto_app_naming_enabled", value);
    }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoTransactionNamingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_transaction_naming_enabled");
        set => SetArgument("auto_transaction_naming_enabled", value);
    }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomTracingEnabled
    {
        get => new TerraformReference<bool>(this, "custom_tracing_enabled");
        set => SetArgument("custom_tracing_enabled", value);
    }

    /// <summary>
    /// The globally_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? GloballyEnabled
    {
        get => new TerraformReference<bool>(this, "globally_enabled");
        set => SetArgument("globally_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseKey is required")]
    public required TerraformValue<string> LicenseKey
    {
        get => new TerraformReference<string>(this, "license_key");
        set => SetArgument("license_key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformValue<string> SpringCloudServiceId
    {
        get => new TerraformReference<string>(this, "spring_cloud_service_id");
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
