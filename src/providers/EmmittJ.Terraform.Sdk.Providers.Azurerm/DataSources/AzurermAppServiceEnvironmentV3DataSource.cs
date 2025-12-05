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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        => CreateReference("allow_new_private_endpoint_connections");

    /// <summary>
    /// The cluster_setting attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterSetting
        => CreateReference("cluster_setting");

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformValue<double> DedicatedHostCount
        => CreateReference("dedicated_host_count");

    /// <summary>
    /// The dns_suffix attribute.
    /// </summary>
    public TerraformValue<string> DnsSuffix
        => CreateReference("dns_suffix");

    /// <summary>
    /// The external_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> ExternalInboundIpAddresses
        => CreateReference("external_inbound_ip_addresses");

    /// <summary>
    /// The inbound_network_dependencies attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InboundNetworkDependencies
        => CreateReference("inbound_network_dependencies");

    /// <summary>
    /// The internal_inbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> InternalInboundIpAddresses
        => CreateReference("internal_inbound_ip_addresses");

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string> InternalLoadBalancingMode
        => CreateReference("internal_load_balancing_mode");

    /// <summary>
    /// The ip_ssl_address_count attribute.
    /// </summary>
    public TerraformValue<double> IpSslAddressCount
        => CreateReference("ip_ssl_address_count");

    /// <summary>
    /// The linux_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> LinuxOutboundIpAddresses
        => CreateReference("linux_outbound_ip_addresses");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The pricing_tier attribute.
    /// </summary>
    public TerraformValue<string> PricingTier
        => CreateReference("pricing_tier");

    /// <summary>
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RemoteDebuggingEnabled
        => CreateReference("remote_debugging_enabled");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string> SubnetId
        => CreateReference("subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WindowsOutboundIpAddresses
        => CreateReference("windows_outbound_ip_addresses");

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
        => CreateReference("zone_redundant");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceEnvironmentV3DataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
