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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for link1 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink1Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "link1";

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformArgument("admin_enabled")]
    public TerraformValue<bool>? AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
        set => SetArgument("admin_enabled", value);
    }




    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformArgument("macsec_cak_keyvault_secret_id")]
    public TerraformValue<string>? MacsecCakKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_cak_keyvault_secret_id");
        set => SetArgument("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformArgument("macsec_cipher")]
    public TerraformValue<string>? MacsecCipher
    {
        get => new TerraformReference<string>(this, "macsec_cipher");
        set => SetArgument("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformArgument("macsec_ckn_keyvault_secret_id")]
    public TerraformValue<string>? MacsecCknKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_ckn_keyvault_secret_id");
        set => SetArgument("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformArgument("macsec_sci_enabled")]
    public TerraformValue<bool>? MacsecSciEnabled
    {
        get => new TerraformReference<bool>(this, "macsec_sci_enabled");
        set => SetArgument("macsec_sci_enabled", value);
    }




}

/// <summary>
/// Block type for link2 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "link2";

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformArgument("admin_enabled")]
    public TerraformValue<bool>? AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
        set => SetArgument("admin_enabled", value);
    }




    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    [TerraformArgument("macsec_cak_keyvault_secret_id")]
    public TerraformValue<string>? MacsecCakKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_cak_keyvault_secret_id");
        set => SetArgument("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    [TerraformArgument("macsec_cipher")]
    public TerraformValue<string>? MacsecCipher
    {
        get => new TerraformReference<string>(this, "macsec_cipher");
        set => SetArgument("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    [TerraformArgument("macsec_ckn_keyvault_secret_id")]
    public TerraformValue<string>? MacsecCknKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_ckn_keyvault_secret_id");
        set => SetArgument("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    [TerraformArgument("macsec_sci_enabled")]
    public TerraformValue<bool>? MacsecSciEnabled
    {
        get => new TerraformReference<bool>(this, "macsec_sci_enabled");
        set => SetArgument("macsec_sci_enabled", value);
    }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRoutePortTimeoutsBlock : TerraformBlock
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
    [TerraformArgument("bandwidth_in_gbps")]
    public required TerraformValue<double> BandwidthInGbps
    {
        get => new TerraformReference<double>(this, "bandwidth_in_gbps");
        set => SetArgument("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    [TerraformArgument("billing_type")]
    public TerraformValue<string>? BillingType
    {
        get => new TerraformReference<string>(this, "billing_type");
        set => SetArgument("billing_type", value);
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    [TerraformArgument("encapsulation")]
    public required TerraformValue<string> Encapsulation
    {
        get => new TerraformReference<string>(this, "encapsulation");
        set => SetArgument("encapsulation", value);
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
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    [TerraformArgument("peering_location")]
    public required TerraformValue<string> PeeringLocation
    {
        get => new TerraformReference<string>(this, "peering_location");
        set => SetArgument("peering_location", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermExpressRoutePortIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for link1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    [TerraformArgument("link1")]
    public TerraformList<AzurermExpressRoutePortLink1Block> Link1 { get; set; } = new();

    /// <summary>
    /// Block for link2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    [TerraformArgument("link2")]
    public TerraformList<AzurermExpressRoutePortLink2Block> Link2 { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermExpressRoutePortTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    [TerraformArgument("ethertype")]
    public TerraformValue<string> Ethertype
    {
        get => new TerraformReference<string>(this, "ethertype");
    }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    [TerraformArgument("guid")]
    public TerraformValue<string> Guid
    {
        get => new TerraformReference<string>(this, "guid");
    }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    [TerraformArgument("mtu")]
    public TerraformValue<string> Mtu
    {
        get => new TerraformReference<string>(this, "mtu");
    }

}
