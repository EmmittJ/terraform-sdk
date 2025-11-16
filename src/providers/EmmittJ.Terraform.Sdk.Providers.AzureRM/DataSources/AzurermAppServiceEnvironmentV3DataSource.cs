using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_app_service_environment_v3 Terraform data source.
/// Retrieves information about a azurerm_app_service_environment_v3.
/// </summary>
public partial class AzurermAppServiceEnvironmentV3DataSource(string name) : TerraformDataSource("azurerm_app_service_environment_v3", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public TerraformValue<bool> AllowNewPrivateEndpointConnections
    {
        get => new TerraformReference<bool>(this, "allow_new_private_endpoint_connections");
    }

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterSetting
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_setting").ResolveNodes(ctx));
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformValue<double> DedicatedHostCount
    {
        get => new TerraformReference<double>(this, "dedicated_host_count");
    }

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
    {
        get => new TerraformReference<string>(this, "dns_suffix");
    }

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ExternalInboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "external_inbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InboundNetworkDependencies
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "inbound_network_dependencies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> InternalInboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "internal_inbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string> InternalLoadBalancingMode
    {
        get => new TerraformReference<string>(this, "internal_load_balancing_mode");
    }

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    public TerraformValue<double> IpSslAddressCount
    {
        get => new TerraformReference<double>(this, "ip_ssl_address_count");
    }

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> LinuxOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "linux_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformValue<string> PricingTier
    {
        get => new TerraformReference<string>(this, "pricing_tier");
    }

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WindowsOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "windows_outbound_ip_addresses").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
