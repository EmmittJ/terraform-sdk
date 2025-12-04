using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_configuration in AzurermPrivateEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_configuration";

    /// <summary>
    /// The member_name attribute.
    /// </summary>
    public TerraformValue<string>? MemberName
    {
        get => GetArgument<TerraformValue<string>>("member_name");
        set => SetArgument("member_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => GetArgument<TerraformValue<string>>("private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public TerraformValue<string>? SubresourceName
    {
        get => GetArgument<TerraformValue<string>>("subresource_name");
        set => SetArgument("subresource_name", value);
    }

}


/// <summary>
/// Block type for private_dns_zone_group in AzurermPrivateEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointPrivateDnsZoneGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_dns_zone_group";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneIds is required")]
    public TerraformList<string>? PrivateDnsZoneIds
    {
        get => GetArgument<TerraformList<string>>("private_dns_zone_ids");
        set => SetArgument("private_dns_zone_ids", value);
    }

}


/// <summary>
/// Block type for private_service_connection in AzurermPrivateEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointPrivateServiceConnectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_service_connection";

    /// <summary>
    /// The is_manual_connection attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsManualConnection is required")]
    public required TerraformValue<bool> IsManualConnection
    {
        get => GetArgument<TerraformValue<bool>>("is_manual_connection");
        set => SetArgument("is_manual_connection", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_connection_resource_alias attribute.
    /// </summary>
    public TerraformValue<string>? PrivateConnectionResourceAlias
    {
        get => GetArgument<TerraformValue<string>>("private_connection_resource_alias");
        set => SetArgument("private_connection_resource_alias", value);
    }

    /// <summary>
    /// The private_connection_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? PrivateConnectionResourceId
    {
        get => GetArgument<TerraformValue<string>>("private_connection_resource_id");
        set => SetArgument("private_connection_resource_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
        => AsReference("private_ip_address");

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformValue<string>? RequestMessage
    {
        get => GetArgument<TerraformValue<string>>("request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The subresource_names attribute.
    /// </summary>
    public TerraformList<string>? SubresourceNames
    {
        get => GetArgument<TerraformList<string>>("subresource_names");
        set => SetArgument("subresource_names", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPrivateEndpoint.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateEndpointTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_private_endpoint Terraform resource.
/// Manages a azurerm_private_endpoint resource.
/// </summary>
public partial class AzurermPrivateEndpoint(string name) : TerraformResource("azurerm_private_endpoint", name)
{
    /// <summary>
    /// The custom_network_interface_name attribute.
    /// </summary>
    public TerraformValue<string>? CustomNetworkInterfaceName
    {
        get => GetArgument<TerraformValue<string>>("custom_network_interface_name");
        set => SetArgument("custom_network_interface_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
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
    /// The custom_dns_configs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomDnsConfigs
        => AsReference("custom_dns_configs");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NetworkInterface
        => AsReference("network_interface");

    /// <summary>
    /// The private_dns_zone_configs attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivateDnsZoneConfigs
        => AsReference("private_dns_zone_configs");

    /// <summary>
    /// IpConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermPrivateEndpointIpConfigurationBlock>? IpConfiguration
    {
        get => GetArgument<TerraformList<AzurermPrivateEndpointIpConfigurationBlock>>("ip_configuration");
        set => SetArgument("ip_configuration", value);
    }

    /// <summary>
    /// PrivateDnsZoneGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsZoneGroup block(s) allowed")]
    public TerraformList<AzurermPrivateEndpointPrivateDnsZoneGroupBlock>? PrivateDnsZoneGroup
    {
        get => GetArgument<TerraformList<AzurermPrivateEndpointPrivateDnsZoneGroupBlock>>("private_dns_zone_group");
        set => SetArgument("private_dns_zone_group", value);
    }

    /// <summary>
    /// PrivateServiceConnection block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateServiceConnection is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivateServiceConnection block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnection block(s) allowed")]
    public required TerraformList<AzurermPrivateEndpointPrivateServiceConnectionBlock> PrivateServiceConnection
    {
        get => GetRequiredArgument<TerraformList<AzurermPrivateEndpointPrivateServiceConnectionBlock>>("private_service_connection");
        set => SetArgument("private_service_connection", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
