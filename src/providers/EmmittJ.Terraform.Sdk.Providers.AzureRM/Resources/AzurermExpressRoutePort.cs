using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRoutePortIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for link1 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRoutePortLink1Block() : TerraformBlock("link1")
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformProperty("admin_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdminEnabled { get; set; }




    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformProperty("macsec_cak_keyvault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformProperty("macsec_cipher")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacsecCipher { get; set; }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformProperty("macsec_ckn_keyvault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformProperty("macsec_sci_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MacsecSciEnabled { get; set; }




}

/// <summary>
/// Block type for link2 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermExpressRoutePortLink2Block() : TerraformBlock("link2")
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformProperty("admin_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AdminEnabled { get; set; }




    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformProperty("macsec_cak_keyvault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacsecCakKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformProperty("macsec_cipher")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacsecCipher { get; set; }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformProperty("macsec_ckn_keyvault_secret_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MacsecCknKeyvaultSecretId { get; set; }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformProperty("macsec_sci_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MacsecSciEnabled { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermExpressRoutePortTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_express_route_port resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermExpressRoutePort : TerraformResource
{
    public AzurermExpressRoutePort(string name) : base("azurerm_express_route_port", name)
    {
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthInGbps is required")]
    [TerraformProperty("bandwidth_in_gbps")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> BandwidthInGbps { get; set; }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    [TerraformProperty("billing_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BillingType { get; set; }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    [TerraformProperty("encapsulation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Encapsulation { get; set; }

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
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    [TerraformProperty("peering_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PeeringLocation { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermExpressRoutePortIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for link1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    [TerraformProperty("link1")]
    public TerraformList<AzurermExpressRoutePortLink1Block> Link1 { get; set; } = new();

    /// <summary>
    /// Block for link2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    [TerraformProperty("link2")]
    public TerraformList<AzurermExpressRoutePortLink2Block> Link2 { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermExpressRoutePortTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    [TerraformProperty("ethertype")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Ethertype { get; }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformProperty("guid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Guid { get; }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformProperty("mtu")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Mtu { get; }

}
