using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for link1 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink1Block
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AdminEnabled { get; set; }




    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cak_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cipher")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MacsecCipher { get; set; }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_ckn_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformPropertyName("macsec_sci_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MacsecSciEnabled { get; set; }




}

/// <summary>
/// Block type for link2 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink2Block
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AdminEnabled { get; set; }




    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cak_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformPropertyName("macsec_cipher")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MacsecCipher { get; set; }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformPropertyName("macsec_ckn_keyvault_secret_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformPropertyName("macsec_sci_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MacsecSciEnabled { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRoutePortTimeoutsBlock
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
    public required TerraformValue<double> BandwidthInGbps { get; set; }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    [TerraformPropertyName("billing_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BillingType { get; set; }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    [TerraformPropertyName("encapsulation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Encapsulation { get; set; }

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
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    [TerraformPropertyName("peering_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PeeringLocation { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermExpressRoutePortIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for link1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    [TerraformPropertyName("link1")]
    public TerraformList<TerraformBlock<AzurermExpressRoutePortLink1Block>>? Link1 { get; set; }

    /// <summary>
    /// Block for link2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    [TerraformPropertyName("link2")]
    public TerraformList<TerraformBlock<AzurermExpressRoutePortLink2Block>>? Link2 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExpressRoutePortTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    [TerraformPropertyName("ethertype")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Ethertype => new TerraformReference(this, "ethertype");

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformPropertyName("guid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Guid => new TerraformReference(this, "guid");

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformPropertyName("mtu")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Mtu => new TerraformReference(this, "mtu");

}
