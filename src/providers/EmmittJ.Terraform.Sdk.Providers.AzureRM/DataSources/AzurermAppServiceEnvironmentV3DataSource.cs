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
public class AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_app_service_environment_v3.
/// </summary>
public class AzurermAppServiceEnvironmentV3DataSource : TerraformDataSource
{
    public AzurermAppServiceEnvironmentV3DataSource(string name) : base("azurerm_app_service_environment_v3", name)
    {
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    [TerraformArgument("allow_new_private_endpoint_connections")]
    public TerraformValue<bool> AllowNewPrivateEndpointConnections
    {
        get => new TerraformReference<bool>(this, "allow_new_private_endpoint_connections");
    }

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    [TerraformArgument("cluster_setting")]
    public TerraformList<object> ClusterSetting
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "cluster_setting").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    [TerraformArgument("dedicated_host_count")]
    public TerraformValue<double> DedicatedHostCount
    {
        get => new TerraformReference<double>(this, "dedicated_host_count");
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    [TerraformArgument("dns_suffix")]
    public TerraformValue<string> DnsSuffix
    {
        get => new TerraformReference<string>(this, "dns_suffix");
    }

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("external_inbound_ip_addresses")]
    public TerraformList<string> ExternalInboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_inbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    [TerraformArgument("inbound_network_dependencies")]
    public TerraformList<object> InboundNetworkDependencies
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "inbound_network_dependencies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("internal_inbound_ip_addresses")]
    public TerraformList<string> InternalInboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "internal_inbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    [TerraformArgument("internal_load_balancing_mode")]
    public TerraformValue<string> InternalLoadBalancingMode
    {
        get => new TerraformReference<string>(this, "internal_load_balancing_mode");
    }

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    [TerraformArgument("ip_ssl_address_count")]
    public TerraformValue<double> IpSslAddressCount
    {
        get => new TerraformReference<double>(this, "ip_ssl_address_count");
    }

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("linux_outbound_ip_addresses")]
    public TerraformList<string> LinuxOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "linux_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    [TerraformArgument("pricing_tier")]
    public TerraformValue<string> PricingTier
    {
        get => new TerraformReference<string>(this, "pricing_tier");
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    [TerraformArgument("remote_debugging_enabled")]
    public TerraformValue<bool> RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformArgument("subnet_id")]
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    [TerraformArgument("windows_outbound_ip_addresses")]
    public TerraformList<string> WindowsOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "windows_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

}
