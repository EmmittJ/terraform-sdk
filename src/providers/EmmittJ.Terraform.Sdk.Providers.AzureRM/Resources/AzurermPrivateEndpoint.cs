using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointIpConfigurationBlock
{
    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [TerraformPropertyName("member_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MemberName { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformPropertyName("private_ip_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    [TerraformPropertyName("subresource_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubresourceName { get; set; }

}

/// <summary>
/// Block type for private_dns_zone_group in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointPrivateDnsZoneGroupBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneIds is required")]
    [TerraformPropertyName("private_dns_zone_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? PrivateDnsZoneIds { get; set; }

}

/// <summary>
/// Block type for private_service_connection in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointPrivateServiceConnectionBlock
{
    /// <summary>
    /// The is_manual_connection attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsManualConnection is required")]
    [TerraformPropertyName("is_manual_connection")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> IsManualConnection { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_connection_resource_alias attribute.
    /// </summary>
    [TerraformPropertyName("private_connection_resource_alias")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateConnectionResourceAlias { get; set; }

    /// <summary>
    /// The private_connection_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("private_connection_resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateConnectionResourceId { get; set; }


    /// <summary>
    /// The request_message attribute.
    /// </summary>
    [TerraformPropertyName("request_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RequestMessage { get; set; }

    /// <summary>
    /// The subresource_names attribute.
    /// </summary>
    [TerraformPropertyName("subresource_names")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? SubresourceNames { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateEndpointTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("custom_network_interface_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomNetworkInterfaceName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    public TerraformList<TerraformBlock<AzurermPrivateEndpointIpConfigurationBlock>>? IpConfiguration { get; set; }

    /// <summary>
    /// Block for private_dns_zone_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsZoneGroup block(s) allowed")]
    [TerraformPropertyName("private_dns_zone_group")]
    public TerraformList<TerraformBlock<AzurermPrivateEndpointPrivateDnsZoneGroupBlock>>? PrivateDnsZoneGroup { get; set; }

    /// <summary>
    /// Block for private_service_connection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateServiceConnection is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivateServiceConnection block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnection block(s) allowed")]
    [TerraformPropertyName("private_service_connection")]
    public TerraformList<TerraformBlock<AzurermPrivateEndpointPrivateServiceConnectionBlock>>? PrivateServiceConnection { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPrivateEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_dns_configs attribute.
    /// </summary>
    [TerraformPropertyName("custom_dns_configs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomDnsConfigs => new TerraformReference(this, "custom_dns_configs");

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformPropertyName("network_interface")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NetworkInterface => new TerraformReference(this, "network_interface");

    /// <summary>
    /// The private_dns_zone_configs attribute.
    /// </summary>
    [TerraformPropertyName("private_dns_zone_configs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivateDnsZoneConfigs => new TerraformReference(this, "private_dns_zone_configs");

}
