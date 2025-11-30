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
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<bool>(this, "allow_new_private_endpoint_connections");
        set => SetArgument("allow_new_private_endpoint_connections", value);
    }

    /// <summary>
    /// The dedicated_host_count attribute.
    /// </summary>
    public TerraformValue<double>? DedicatedHostCount
    {
        get => new TerraformReference<double>(this, "dedicated_host_count");
        set => SetArgument("dedicated_host_count", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internal_load_balancing_mode attribute.
    /// </summary>
    public TerraformValue<string>? InternalLoadBalancingMode
    {
        get => new TerraformReference<string>(this, "internal_load_balancing_mode");
        set => SetArgument("internal_load_balancing_mode", value);
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
    /// The remote_debugging_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemoteDebuggingEnabled
    {
        get => new TerraformReference<bool>(this, "remote_debugging_enabled");
        set => SetArgument("remote_debugging_enabled", value);
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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
        set => SetArgument("zone_redundant", value);
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
    /// The windows_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> WindowsOutboundIpAddresses
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "windows_outbound_ip_addresses").ResolveNodes(ctx));
    }

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
