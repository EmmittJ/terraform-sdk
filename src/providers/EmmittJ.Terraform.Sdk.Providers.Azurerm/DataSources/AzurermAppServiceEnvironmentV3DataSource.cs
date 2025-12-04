using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceEnvironmentV3DataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public TerraformValue<bool> AllowNewPrivateEndpointConnections
        => AsReference("allow_new_private_endpoint_connections");

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterSetting
        => AsReference("cluster_setting");

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformValue<double> DedicatedHostCount
        => AsReference("dedicated_host_count");

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
        => AsReference("dns_suffix");

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ExternalInboundIpAddresses
        => AsReference("external_inbound_ip_addresses");

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InboundNetworkDependencies
        => AsReference("inbound_network_dependencies");

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> InternalInboundIpAddresses
        => AsReference("internal_inbound_ip_addresses");

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string> InternalLoadBalancingMode
        => AsReference("internal_load_balancing_mode");

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    public TerraformValue<double> IpSslAddressCount
        => AsReference("ip_ssl_address_count");

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> LinuxOutboundIpAddresses
        => AsReference("linux_outbound_ip_addresses");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformValue<string> PricingTier
        => AsReference("pricing_tier");

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RemoteDebuggingEnabled
        => AsReference("remote_debugging_enabled");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => AsReference("subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WindowsOutboundIpAddresses
        => AsReference("windows_outbound_ip_addresses");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
        => AsReference("zone_redundant");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
