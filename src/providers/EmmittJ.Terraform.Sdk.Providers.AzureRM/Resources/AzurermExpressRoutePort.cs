using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermExpressRoutePort.
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
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for link1 in AzurermExpressRoutePort.
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
    public TerraformValue<bool>? AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public TerraformValue<string> ConnectorType
    {
        get => new TerraformReference<string>(this, "connector_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    public TerraformValue<string> InterfaceName
    {
        get => new TerraformReference<string>(this, "interface_name");
    }

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? MacsecCakKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_cak_keyvault_secret_id");
        set => SetArgument("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    public TerraformValue<string>? MacsecCipher
    {
        get => new TerraformReference<string>(this, "macsec_cipher");
        set => SetArgument("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? MacsecCknKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_ckn_keyvault_secret_id");
        set => SetArgument("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MacsecSciEnabled
    {
        get => new TerraformReference<bool>(this, "macsec_sci_enabled");
        set => SetArgument("macsec_sci_enabled", value);
    }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    public TerraformValue<string> PatchPanelId
    {
        get => new TerraformReference<string>(this, "patch_panel_id");
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformValue<string> RackId
    {
        get => new TerraformReference<string>(this, "rack_id");
    }

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    public TerraformValue<string> RouterName
    {
        get => new TerraformReference<string>(this, "router_name");
    }

}


/// <summary>
/// Block type for link2 in AzurermExpressRoutePort.
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
    public TerraformValue<bool>? AdminEnabled
    {
        get => new TerraformReference<bool>(this, "admin_enabled");
        set => SetArgument("admin_enabled", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public TerraformValue<string> ConnectorType
    {
        get => new TerraformReference<string>(this, "connector_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    public TerraformValue<string> InterfaceName
    {
        get => new TerraformReference<string>(this, "interface_name");
    }

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? MacsecCakKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_cak_keyvault_secret_id");
        set => SetArgument("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    public TerraformValue<string>? MacsecCipher
    {
        get => new TerraformReference<string>(this, "macsec_cipher");
        set => SetArgument("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? MacsecCknKeyvaultSecretId
    {
        get => new TerraformReference<string>(this, "macsec_ckn_keyvault_secret_id");
        set => SetArgument("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MacsecSciEnabled
    {
        get => new TerraformReference<bool>(this, "macsec_sci_enabled");
        set => SetArgument("macsec_sci_enabled", value);
    }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    public TerraformValue<string> PatchPanelId
    {
        get => new TerraformReference<string>(this, "patch_panel_id");
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformValue<string> RackId
    {
        get => new TerraformReference<string>(this, "rack_id");
    }

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    public TerraformValue<string> RouterName
    {
        get => new TerraformReference<string>(this, "router_name");
    }

}


/// <summary>
/// Block type for timeouts in AzurermExpressRoutePort.
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
/// Represents a azurerm_express_route_port Terraform resource.
/// Manages a azurerm_express_route_port resource.
/// </summary>
public partial class AzurermExpressRoutePort(string name) : TerraformResource("azurerm_express_route_port", name)
{
    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthInGbps is required")]
    public required TerraformValue<double> BandwidthInGbps
    {
        get => new TerraformReference<double>(this, "bandwidth_in_gbps");
        set => SetArgument("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    public TerraformValue<string>? BillingType
    {
        get => new TerraformReference<string>(this, "billing_type");
        set => SetArgument("billing_type", value);
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    public required TerraformValue<string> Encapsulation
    {
        get => new TerraformReference<string>(this, "encapsulation");
        set => SetArgument("encapsulation", value);
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
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    public required TerraformValue<string> PeeringLocation
    {
        get => new TerraformReference<string>(this, "peering_location");
        set => SetArgument("peering_location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    public TerraformValue<string> Ethertype
    {
        get => new TerraformReference<string>(this, "ethertype");
    }

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformValue<string> Guid
    {
        get => new TerraformReference<string>(this, "guid");
    }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformValue<string> Mtu
    {
        get => new TerraformReference<string>(this, "mtu");
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermExpressRoutePortIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermExpressRoutePortIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Link1 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    public TerraformList<AzurermExpressRoutePortLink1Block>? Link1
    {
        get => GetArgument<TerraformList<AzurermExpressRoutePortLink1Block>>("link1");
        set => SetArgument("link1", value);
    }

    /// <summary>
    /// Link2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    public TerraformList<AzurermExpressRoutePortLink2Block>? Link2
    {
        get => GetArgument<TerraformList<AzurermExpressRoutePortLink2Block>>("link2");
        set => SetArgument("link2", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExpressRoutePortTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExpressRoutePortTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
