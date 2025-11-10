using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerProfileDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The relative_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelativeName is required")]
    public required TerraformProperty<string> RelativeName
    {
        get => GetProperty<TerraformProperty<string>>("relative_name");
        set => WithProperty("relative_name", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformProperty<double> Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => WithProperty("ttl", value);
    }

}

/// <summary>
/// Block type for monitor_config in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerProfileMonitorConfigBlock : TerraformBlock
{
    /// <summary>
    /// The expected_status_code_ranges attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ExpectedStatusCodeRanges
    {
        get => GetProperty<List<TerraformProperty<string>>>("expected_status_code_ranges");
        set => WithProperty("expected_status_code_ranges", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_seconds");
        set => WithProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_in_seconds");
        set => WithProperty("timeout_in_seconds", value);
    }

    /// <summary>
    /// The tolerated_number_of_failures attribute.
    /// </summary>
    public TerraformProperty<double>? ToleratedNumberOfFailures
    {
        get => GetProperty<TerraformProperty<double>>("tolerated_number_of_failures");
        set => WithProperty("tolerated_number_of_failures", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerProfileTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_traffic_manager_profile resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermTrafficManagerProfile : TerraformResource
{
    public AzurermTrafficManagerProfile(string name) : base("azurerm_traffic_manager_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
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
    /// The max_return attribute.
    /// </summary>
    public TerraformProperty<double>? MaxReturn
    {
        get => GetProperty<TerraformProperty<double>>("max_return");
        set => this.WithProperty("max_return", value);
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
    /// The profile_status attribute.
    /// </summary>
    public TerraformProperty<string>? ProfileStatus
    {
        get => GetProperty<TerraformProperty<string>>("profile_status");
        set => this.WithProperty("profile_status", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The traffic_routing_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrafficRoutingMethod is required")]
    public required TerraformProperty<string> TrafficRoutingMethod
    {
        get => GetProperty<TerraformProperty<string>>("traffic_routing_method");
        set => this.WithProperty("traffic_routing_method", value);
    }

    /// <summary>
    /// The traffic_view_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TrafficViewEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("traffic_view_enabled");
        set => this.WithProperty("traffic_view_enabled", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DnsConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public List<AzurermTrafficManagerProfileDnsConfigBlock>? DnsConfig
    {
        get => GetProperty<List<AzurermTrafficManagerProfileDnsConfigBlock>>("dns_config");
        set => this.WithProperty("dns_config", value);
    }

    /// <summary>
    /// Block for monitor_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitorConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitorConfig block(s) allowed")]
    public List<AzurermTrafficManagerProfileMonitorConfigBlock>? MonitorConfig
    {
        get => GetProperty<List<AzurermTrafficManagerProfileMonitorConfigBlock>>("monitor_config");
        set => this.WithProperty("monitor_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermTrafficManagerProfileTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermTrafficManagerProfileTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
