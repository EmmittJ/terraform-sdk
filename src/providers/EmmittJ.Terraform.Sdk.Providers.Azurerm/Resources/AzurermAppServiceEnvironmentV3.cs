using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cluster_setting in AzurermAppServiceEnvironmentV3.
/// Nesting mode: list
/// </summary>
public class AzurermAppServiceEnvironmentV3ClusterSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_setting";

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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermAppServiceEnvironmentV3.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceEnvironmentV3TimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_app_service_environment_v3 Terraform resource.
/// Manages a azurerm_app_service_environment_v3 resource.
/// </summary>
public partial class AzurermAppServiceEnvironmentV3(string name) : TerraformResource("azurerm_app_service_environment_v3", name)
{
    /// <summary>
    /// The allow_new_private_endpoint_connections attribute.
    /// </summary>
    public TerraformValue<bool>? AllowNewPrivateEndpointConnections
    {
        get => GetArgument<TerraformValue<bool>>("allow_new_private_endpoint_connections");
        set => SetArgument("allow_new_private_endpoint_connections", value);
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformValue<double>? DedicatedHostCount
    {
        get => GetArgument<TerraformValue<double>>("dedicated_host_count");
        set => SetArgument("dedicated_host_count", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string>? InternalLoadBalancingMode
    {
        get => GetArgument<TerraformValue<string>>("internal_load_balancing_mode");
        set => SetArgument("internal_load_balancing_mode", value);
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
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

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
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WindowsOutboundIpAddresses
        => AsReference("windows_outbound_ip_addresses");

    /// <summary>
    /// ClusterSetting block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermAppServiceEnvironmentV3ClusterSettingBlock>? ClusterSetting
    {
        get => GetArgument<TerraformList<AzurermAppServiceEnvironmentV3ClusterSettingBlock>>("cluster_setting");
        set => SetArgument("cluster_setting", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceEnvironmentV3TimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceEnvironmentV3TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
