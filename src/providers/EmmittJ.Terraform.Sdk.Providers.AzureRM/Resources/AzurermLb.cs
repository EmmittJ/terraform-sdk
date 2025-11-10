using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for frontend_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermLbFrontendIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The gateway_load_balancer_frontend_ip_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("gateway_load_balancer_frontend_ip_configuration_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GatewayLoadBalancerFrontendIpConfigurationId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "gateway_load_balancer_frontend_ip_configuration_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The inbound_nat_rules attribute.
    /// </summary>
    [TerraformPropertyName("inbound_nat_rules")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> InboundNatRules => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "inbound_nat_rules");

    /// <summary>
    /// The load_balancer_rules attribute.
    /// </summary>
    [TerraformPropertyName("load_balancer_rules")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LoadBalancerRules => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "load_balancer_rules");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The outbound_rules attribute.
    /// </summary>
    [TerraformPropertyName("outbound_rules")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> OutboundRules => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "outbound_rules");

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address");

    /// <summary>
    /// The private_ip_address_allocation attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_allocation")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddressAllocation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address_allocation");

    /// <summary>
    /// The private_ip_address_version attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddressVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "private_ip_address_version");

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicIpAddressId { get; set; }

    /// <summary>
    /// The public_ip_prefix_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_prefix_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicIpPrefixId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "public_ip_prefix_id");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Zones { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLbTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_lb resource.
/// </summary>
public class AzurermLb : TerraformResource
{
    public AzurermLb(string name) : base("azurerm_lb", name)
    {
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    [TerraformPropertyName("edge_zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EdgeZone { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    [TerraformPropertyName("public_ip_address_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PublicIpAddressId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_ip_address_id");

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Sku { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformPropertyName("sku_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SkuTier { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for frontend_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("frontend_ip_configuration")]
    public TerraformList<TerraformBlock<AzurermLbFrontendIpConfigurationBlock>>? FrontendIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermLbTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_ip_address");

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("private_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> PrivateIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "private_ip_addresses");

}
