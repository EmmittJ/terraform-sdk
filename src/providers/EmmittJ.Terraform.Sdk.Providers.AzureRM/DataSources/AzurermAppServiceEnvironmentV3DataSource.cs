using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_environment_v3.
/// </summary>
public class AzurermAppServiceEnvironmentV3DataSource : TerraformDataSource
{
    public AzurermAppServiceEnvironmentV3DataSource(string name) : base("azurerm_app_service_environment_v3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allow_new_private_endpoint_connections");
        SetOutput("cluster_setting");
        SetOutput("dedicated_host_count");
        SetOutput("dns_suffix");
        SetOutput("external_inbound_ip_addresses");
        SetOutput("inbound_network_dependencies");
        SetOutput("internal_inbound_ip_addresses");
        SetOutput("internal_load_balancing_mode");
        SetOutput("ip_ssl_address_count");
        SetOutput("linux_outbound_ip_addresses");
        SetOutput("location");
        SetOutput("pricing_tier");
        SetOutput("remote_debugging_enabled");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("windows_outbound_ip_addresses");
        SetOutput("zone_redundant");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public TerraformExpression AllowNewPrivateEndpointConnections => this["allow_new_private_endpoint_connections"];

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    public TerraformExpression ClusterSetting => this["cluster_setting"];

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformExpression DedicatedHostCount => this["dedicated_host_count"];

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
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformExpression InternalLoadBalancingMode => this["internal_load_balancing_mode"];

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
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformExpression RemoteDebuggingEnabled => this["remote_debugging_enabled"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression WindowsOutboundIpAddresses => this["windows_outbound_ip_addresses"];

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformExpression ZoneRedundant => this["zone_redundant"];

}
