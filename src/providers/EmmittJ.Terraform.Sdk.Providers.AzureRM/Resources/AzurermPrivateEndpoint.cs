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
    [TerraformArgument("member_name")]
    public TerraformValue<string> MemberName
    {
        get => new TerraformReference<string>(this, "member_name");
        set => SetArgument("member_name", value);
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
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformArgument("private_ip_address")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    [TerraformArgument("subresource_name")]
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
    /// The private_dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneIds is required")]
    [TerraformArgument("private_dns_zone_ids")]
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
    [TerraformArgument("is_manual_connection")]
    public required TerraformValue<bool> IsManualConnection
    {
        get => new TerraformReference<bool>(this, "is_manual_connection");
        set => SetArgument("is_manual_connection", value);
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
    /// The private_connection_resource_alias attribute.
    /// </summary>
    [TerraformArgument("private_connection_resource_alias")]
    public TerraformValue<string>? PrivateConnectionResourceAlias
    {
        get => new TerraformReference<string>(this, "private_connection_resource_alias");
        set => SetArgument("private_connection_resource_alias", value);
    }

    /// <summary>
    /// The private_connection_resource_id attribute.
    /// </summary>
    [TerraformArgument("private_connection_resource_id")]
    public TerraformValue<string>? PrivateConnectionResourceId
    {
        get => new TerraformReference<string>(this, "private_connection_resource_id");
        set => SetArgument("private_connection_resource_id", value);
    }


    /// <summary>
    /// The request_message attribute.
    /// </summary>
    [TerraformArgument("request_message")]
    public TerraformValue<string>? RequestMessage
    {
        get => new TerraformReference<string>(this, "request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The subresource_names attribute.
    /// </summary>
    [TerraformArgument("subresource_names")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_private_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPrivateEndpoint : TerraformResource
{
    public AzurermPrivateEndpoint(string name) : base("azurerm_private_endpoint", name)
    {
    }

    /// <summary>
    /// The custom_network_interface_name attribute.
    /// </summary>
    [TerraformArgument("custom_network_interface_name")]
    public TerraformValue<string>? CustomNetworkInterfaceName
    {
        get => new TerraformReference<string>(this, "custom_network_interface_name");
        set => SetArgument("custom_network_interface_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("ip_configuration")]
    public TerraformList<AzurermPrivateEndpointIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for private_dns_zone_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsZoneGroup block(s) allowed")]
    [TerraformArgument("private_dns_zone_group")]
    public TerraformList<AzurermPrivateEndpointPrivateDnsZoneGroupBlock> PrivateDnsZoneGroup { get; set; } = new();

    /// <summary>
    /// Block for private_service_connection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateServiceConnection is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivateServiceConnection block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnection block(s) allowed")]
    [TerraformArgument("private_service_connection")]
    public required TerraformList<AzurermPrivateEndpointPrivateServiceConnectionBlock> PrivateServiceConnection { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPrivateEndpointTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_dns_configs attribute.
    /// </summary>
    [TerraformArgument("custom_dns_configs")]
    public TerraformList<object> CustomDnsConfigs
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "custom_dns_configs").ResolveNodes(ctx));
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformArgument("network_interface")]
    public TerraformList<object> NetworkInterface
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "network_interface").ResolveNodes(ctx));
    }

    /// <summary>
    /// The private_dns_zone_configs attribute.
    /// </summary>
    [TerraformArgument("private_dns_zone_configs")]
    public TerraformList<object> PrivateDnsZoneConfigs
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "private_dns_zone_configs").ResolveNodes(ctx));
    }

}
