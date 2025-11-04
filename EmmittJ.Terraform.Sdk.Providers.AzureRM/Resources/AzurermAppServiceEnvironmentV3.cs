using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("dns_suffix");
        this.DeclareOutput("external_inbound_ip_addresses");
        this.DeclareOutput("inbound_network_dependencies");
        this.DeclareOutput("internal_inbound_ip_addresses");
        this.DeclareOutput("ip_ssl_address_count");
        this.DeclareOutput("linux_outbound_ip_addresses");
        this.DeclareOutput("location");
        this.DeclareOutput("pricing_tier");
        this.DeclareOutput("windows_outbound_ip_addresses");
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public bool? AllowNewPrivateEndpointConnections
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_new_private_endpoint_connections")?.Value;
        set => this.WithProperty("allow_new_private_endpoint_connections", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public double? DedicatedHostCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("dedicated_host_count")?.Value;
        set => this.WithProperty("dedicated_host_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public string? InternalLoadBalancingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("internal_load_balancing_mode")?.Value;
        set => this.WithProperty("internal_load_balancing_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public bool? RemoteDebuggingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remote_debugging_enabled")?.Value;
        set => this.WithProperty("remote_debugging_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public bool? ZoneRedundant
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("zone_redundant")?.Value;
        set => this.WithProperty("zone_redundant", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
