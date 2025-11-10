using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IdentityIds { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for link1 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink1Block : ITerraformBlock
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdminEnabled { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [TerraformPropertyName("connector_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectorType => new TerraformReferenceProperty<TerraformProperty<string>>("", "connector_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    [TerraformPropertyName("interface_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InterfaceName => new TerraformReferenceProperty<TerraformProperty<string>>("", "interface_name");

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cak_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cipher")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacsecCipher { get; set; }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_ckn_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformPropertyName("macsec_sci_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MacsecSciEnabled { get; set; }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    [TerraformPropertyName("patch_panel_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PatchPanelId => new TerraformReferenceProperty<TerraformProperty<string>>("", "patch_panel_id");

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    [TerraformPropertyName("rack_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RackId => new TerraformReferenceProperty<TerraformProperty<string>>("", "rack_id");

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    [TerraformPropertyName("router_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouterName => new TerraformReferenceProperty<TerraformProperty<string>>("", "router_name");

}

/// <summary>
/// Block type for link2 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink2Block : ITerraformBlock
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AdminEnabled { get; set; }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [TerraformPropertyName("connector_type")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConnectorType => new TerraformReferenceProperty<TerraformProperty<string>>("", "connector_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    [TerraformPropertyName("interface_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InterfaceName => new TerraformReferenceProperty<TerraformProperty<string>>("", "interface_name");

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cak_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cipher")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacsecCipher { get; set; }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_ckn_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformPropertyName("macsec_sci_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MacsecSciEnabled { get; set; }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    [TerraformPropertyName("patch_panel_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PatchPanelId => new TerraformReferenceProperty<TerraformProperty<string>>("", "patch_panel_id");

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    [TerraformPropertyName("rack_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RackId => new TerraformReferenceProperty<TerraformProperty<string>>("", "rack_id");

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    [TerraformPropertyName("router_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RouterName => new TerraformReferenceProperty<TerraformProperty<string>>("", "router_name");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRoutePortTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_express_route_port resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermExpressRoutePort : TerraformResource
{
    public AzurermExpressRoutePort(string name) : base("azurerm_express_route_port", name)
    {
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthInGbps is required")]
    [TerraformPropertyName("bandwidth_in_gbps")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> BandwidthInGbps { get; set; }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    [TerraformPropertyName("billing_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BillingType { get; set; }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    [TerraformPropertyName("encapsulation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Encapsulation { get; set; }

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
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    [TerraformPropertyName("peering_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PeeringLocation { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermExpressRoutePortIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for link1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    [TerraformPropertyName("link1")]
    public TerraformList<TerraformBlock<AzurermExpressRoutePortLink1Block>>? Link1 { get; set; } = new();

    /// <summary>
    /// Block for link2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    [TerraformPropertyName("link2")]
    public TerraformList<TerraformBlock<AzurermExpressRoutePortLink2Block>>? Link2 { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRoutePortTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    [TerraformPropertyName("ethertype")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ethertype => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ethertype");

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformPropertyName("guid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Guid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "guid");

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformPropertyName("mtu")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Mtu => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mtu");

}
