using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermLbFrontendIpConfigurationBlock() : TerraformBlock("frontend_ip_configuration")
{
    /// <summary>
    /// The gateway_load_balancer_frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformProperty("gateway_load_balancer_frontend_ip_configuration_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> GatewayLoadBalancerFrontendIpConfigurationId { get; set; }




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
    [TerraformProperty("private_ip_address")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_allocation")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIpAddressAllocation { get; set; }

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    [TerraformProperty("private_ip_address_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrivateIpAddressVersion { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_prefix_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicIpPrefixId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLbTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_lb resource.
/// </summary>
public partial class AzurermLb : TerraformResource
{
    public AzurermLb(string name) : base("azurerm_lb", name)
    {
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformProperty("edge_zone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EdgeZone { get; set; }

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
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformProperty("public_ip_address_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PublicIpAddressId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformProperty("sku_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuTier { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("frontend_ip_configuration")]
    public TerraformList<AzurermLbFrontendIpConfigurationBlock> FrontendIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermLbTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformProperty("private_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateIpAddress { get; }

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("private_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> PrivateIpAddresses { get; }

}
