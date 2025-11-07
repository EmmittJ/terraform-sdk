using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("allow_new_private_endpoint_connections");
        this.DeclareOutput("cluster_setting");
        this.DeclareOutput("dedicated_host_count");
        this.DeclareOutput("dns_suffix");
        this.DeclareOutput("external_inbound_ip_addresses");
        this.DeclareOutput("inbound_network_dependencies");
        this.DeclareOutput("internal_inbound_ip_addresses");
        this.DeclareOutput("internal_load_balancing_mode");
        this.DeclareOutput("ip_ssl_address_count");
        this.DeclareOutput("linux_outbound_ip_addresses");
        this.DeclareOutput("location");
        this.DeclareOutput("pricing_tier");
        this.DeclareOutput("remote_debugging_enabled");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("tags");
        this.DeclareOutput("windows_outbound_ip_addresses");
        this.DeclareOutput("zone_redundant");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
