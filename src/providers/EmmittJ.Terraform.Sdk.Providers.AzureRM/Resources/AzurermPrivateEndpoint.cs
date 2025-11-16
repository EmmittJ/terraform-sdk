using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for ip_configuration in .
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
    public TerraformValue<string> MemberName
    {
        get => new TerraformReference<string>(this, "member_name");
        set => SetArgument("member_name", value);
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
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public TerraformValue<string>? SubresourceName
    {
        get => new TerraformReference<string>(this, "subresource_name");
        set => SetArgument("subresource_name", value);
    }

}

/// <summary>
/// Block type for private_dns_zone_group in .
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
    {
        get => new TerraformReference<string>(this, "id");
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
    /// The private_dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneIds is required")]
    public TerraformList<string>? PrivateDnsZoneIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "private_dns_zone_ids").ResolveNodes(ctx));
        set => SetArgument("private_dns_zone_ids", value);
    }

}

/// <summary>
/// Block type for private_service_connection in .
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
        get => new TerraformReference<bool>(this, "is_manual_connection");
        set => SetArgument("is_manual_connection", value);
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
    /// The private_connection_resource_alias attribute.
    /// </summary>
    public TerraformValue<string>? PrivateConnectionResourceAlias
    {
        get => new TerraformReference<string>(this, "private_connection_resource_alias");
        set => SetArgument("private_connection_resource_alias", value);
    }

    /// <summary>
    /// The private_connection_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? PrivateConnectionResourceId
    {
        get => new TerraformReference<string>(this, "private_connection_resource_id");
        set => SetArgument("private_connection_resource_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformValue<string>? RequestMessage
    {
        get => new TerraformReference<string>(this, "request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The subresource_names attribute.
    /// </summary>
    public TerraformList<string>? SubresourceNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "subresource_names").ResolveNodes(ctx));
        set => SetArgument("subresource_names", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "custom_network_interface_name");
        set => SetArgument("custom_network_interface_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
