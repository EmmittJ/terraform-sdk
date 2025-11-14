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
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_new_relic_application_performance_monitoring resource.
/// </summary>
public class AzurermSpringCloudNewRelicApplicationPerformanceMonitoring : TerraformResource
{
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoring(string name) : base("azurerm_spring_cloud_new_relic_application_performance_monitoring", name)
    {
    }

    /// <summary>
    /// The agent_enabled attribute.
    /// </summary>
    [TerraformArgument("agent_enabled")]
    public TerraformValue<bool>? AgentEnabled
    {
        get => new TerraformReference<bool>(this, "agent_enabled");
        set => SetArgument("agent_enabled", value);
    }

    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    [TerraformArgument("app_name")]
    public required TerraformValue<string> AppName
    {
        get => new TerraformReference<string>(this, "app_name");
        set => SetArgument("app_name", value);
    }

    /// <summary>
    /// The app_server_port attribute.
    /// </summary>
    [TerraformArgument("app_server_port")]
    public TerraformValue<double>? AppServerPort
    {
        get => new TerraformReference<double>(this, "app_server_port");
        set => SetArgument("app_server_port", value);
    }

    /// <summary>
    /// The audit_mode_enabled attribute.
    /// </summary>
    [TerraformArgument("audit_mode_enabled")]
    public TerraformValue<bool>? AuditModeEnabled
    {
        get => new TerraformReference<bool>(this, "audit_mode_enabled");
        set => SetArgument("audit_mode_enabled", value);
    }

    /// <summary>
    /// The auto_app_naming_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_app_naming_enabled")]
    public TerraformValue<bool>? AutoAppNamingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_app_naming_enabled");
        set => SetArgument("auto_app_naming_enabled", value);
    }

    /// <summary>
    /// The auto_transaction_naming_enabled attribute.
    /// </summary>
    [TerraformArgument("auto_transaction_naming_enabled")]
    public TerraformValue<bool>? AutoTransactionNamingEnabled
    {
        get => new TerraformReference<bool>(this, "auto_transaction_naming_enabled");
        set => SetArgument("auto_transaction_naming_enabled", value);
    }

    /// <summary>
    /// The custom_tracing_enabled attribute.
    /// </summary>
    [TerraformArgument("custom_tracing_enabled")]
    public TerraformValue<bool>? CustomTracingEnabled
    {
        get => new TerraformReference<bool>(this, "custom_tracing_enabled");
        set => SetArgument("custom_tracing_enabled", value);
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
    /// The labels attribute.
    /// </summary>
    [TerraformArgument("labels")]
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The license_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseKey is required")]
    [TerraformArgument("license_key")]
    public required TerraformValue<string> LicenseKey
    {
        get => new TerraformReference<string>(this, "license_key");
        set => SetArgument("license_key", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudNewRelicApplicationPerformanceMonitoringTimeoutsBlock Timeouts { get; set; } = new();

}
