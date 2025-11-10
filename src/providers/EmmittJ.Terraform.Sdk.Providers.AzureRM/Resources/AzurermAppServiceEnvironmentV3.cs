using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for cluster_setting in .
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceEnvironmentV3ClusterSettingBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3TimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_service_environment_v3 resource.
/// </summary>
public class AzurermAppServiceEnvironmentV3 : TerraformResource
{
    public AzurermAppServiceEnvironmentV3(string name) : base("azurerm_app_service_environment_v3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dns_suffix");
        SetOutput("external_inbound_ip_addresses");
        SetOutput("inbound_network_dependencies");
        SetOutput("internal_inbound_ip_addresses");
        SetOutput("ip_ssl_address_count");
        SetOutput("linux_outbound_ip_addresses");
        SetOutput("location");
        SetOutput("pricing_tier");
        SetOutput("windows_outbound_ip_addresses");
        SetOutput("allow_new_private_endpoint_connections");
        SetOutput("dedicated_host_count");
        SetOutput("id");
        SetOutput("internal_load_balancing_mode");
        SetOutput("name");
        SetOutput("remote_debugging_enabled");
        SetOutput("resource_group_name");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("zone_redundant");
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public TerraformProperty<bool> AllowNewPrivateEndpointConnections
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_new_private_endpoint_connections");
        set => SetProperty("allow_new_private_endpoint_connections", value);
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformProperty<double> DedicatedHostCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("dedicated_host_count");
        set => SetProperty("dedicated_host_count", value);
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
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformProperty<string> InternalLoadBalancingMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("internal_load_balancing_mode");
        set => SetProperty("internal_load_balancing_mode", value);
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
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RemoteDebuggingEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("remote_debugging_enabled");
        set => SetProperty("remote_debugging_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformProperty<bool> ZoneRedundant
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("zone_redundant");
        set => SetProperty("zone_redundant", value);
    }

    /// <summary>
    /// Block for cluster_setting.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermAppServiceEnvironmentV3ClusterSettingBlock>? ClusterSetting
    {
        set => SetProperty("cluster_setting", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceEnvironmentV3TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformExpression DnsSuffix => this["dns_suffix"];

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression ExternalInboundIpAddresses => this["external_inbound_ip_addresses"];

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    public TerraformExpression InboundNetworkDependencies => this["inbound_network_dependencies"];

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression InternalInboundIpAddresses => this["internal_inbound_ip_addresses"];

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    public TerraformExpression IpSslAddressCount => this["ip_ssl_address_count"];

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression LinuxOutboundIpAddresses => this["linux_outbound_ip_addresses"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformExpression PricingTier => this["pricing_tier"];

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WindowsOutboundIpAddresses => this["windows_outbound_ip_addresses"];

}
