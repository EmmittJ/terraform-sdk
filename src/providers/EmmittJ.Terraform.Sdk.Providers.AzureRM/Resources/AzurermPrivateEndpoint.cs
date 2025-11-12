using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPrivateEndpointIpConfigurationBlock() : TerraformBlock("ip_configuration")
{
    /// <summary>
    /// The member_name attribute.
    /// </summary>
    [TerraformProperty("member_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MemberName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformProperty("private_ip_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    [TerraformProperty("subresource_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubresourceName { get; set; }

}

/// <summary>
/// Block type for private_dns_zone_group in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPrivateEndpointPrivateDnsZoneGroupBlock() : TerraformBlock("private_dns_zone_group")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneIds is required")]
    [TerraformProperty("private_dns_zone_ids")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? PrivateDnsZoneIds { get; set; }

}

/// <summary>
/// Block type for private_service_connection in .
/// Nesting mode: list
/// </summary>
public partial class AzurermPrivateEndpointPrivateServiceConnectionBlock() : TerraformBlock("private_service_connection")
{
    /// <summary>
    /// The is_manual_connection attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsManualConnection is required")]
    [TerraformProperty("is_manual_connection")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> IsManualConnection { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The private_connection_resource_alias attribute.
    /// </summary>
    [TerraformProperty("private_connection_resource_alias")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateConnectionResourceAlias { get; set; }

    /// <summary>
    /// The private_connection_resource_id attribute.
    /// </summary>
    [TerraformProperty("private_connection_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateConnectionResourceId { get; set; }


    /// <summary>
    /// The request_message attribute.
    /// </summary>
    [TerraformProperty("request_message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestMessage { get; set; }

    /// <summary>
    /// The subresource_names attribute.
    /// </summary>
    [TerraformProperty("subresource_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? SubresourceNames { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPrivateEndpointTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_private_endpoint resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermPrivateEndpoint : TerraformResource
{
    public AzurermPrivateEndpoint(string name) : base("azurerm_private_endpoint", name)
    {
    }

    /// <summary>
    /// The custom_network_interface_name attribute.
    /// </summary>
    [TerraformProperty("custom_network_interface_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomNetworkInterfaceName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ip_configuration")]
    public TerraformList<AzurermPrivateEndpointIpConfigurationBlock> IpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for private_dns_zone_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsZoneGroup block(s) allowed")]
    [TerraformProperty("private_dns_zone_group")]
    public TerraformList<AzurermPrivateEndpointPrivateDnsZoneGroupBlock> PrivateDnsZoneGroup { get; set; } = new();

    /// <summary>
    /// Block for private_service_connection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateServiceConnection is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivateServiceConnection block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnection block(s) allowed")]
    [TerraformProperty("private_service_connection")]
    public required TerraformList<AzurermPrivateEndpointPrivateServiceConnectionBlock> PrivateServiceConnection { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermPrivateEndpointTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_dns_configs attribute.
    /// </summary>
    [TerraformProperty("custom_dns_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CustomDnsConfigs { get; }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    [TerraformProperty("network_interface")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> NetworkInterface { get; }

    /// <summary>
    /// The private_dns_zone_configs attribute.
    /// </summary>
    [TerraformProperty("private_dns_zone_configs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrivateDnsZoneConfigs { get; }

}
