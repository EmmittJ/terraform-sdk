using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for link1 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink1Block : TerraformBlock
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AdminEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("admin_enabled");
        set => WithProperty("admin_enabled", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorType
    {
        get => GetProperty<TerraformProperty<string>>("connector_type");
        set => WithProperty("connector_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        get => GetProperty<TerraformProperty<string>>("interface_name");
        set => WithProperty("interface_name", value);
    }

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCakKeyvaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("macsec_cak_keyvault_secret_id");
        set => WithProperty("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCipher
    {
        get => GetProperty<TerraformProperty<string>>("macsec_cipher");
        set => WithProperty("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCknKeyvaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("macsec_ckn_keyvault_secret_id");
        set => WithProperty("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MacsecSciEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("macsec_sci_enabled");
        set => WithProperty("macsec_sci_enabled", value);
    }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    public TerraformProperty<string>? PatchPanelId
    {
        get => GetProperty<TerraformProperty<string>>("patch_panel_id");
        set => WithProperty("patch_panel_id", value);
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformProperty<string>? RackId
    {
        get => GetProperty<TerraformProperty<string>>("rack_id");
        set => WithProperty("rack_id", value);
    }

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    public TerraformProperty<string>? RouterName
    {
        get => GetProperty<TerraformProperty<string>>("router_name");
        set => WithProperty("router_name", value);
    }

}

/// <summary>
/// Block type for link2 in .
/// Nesting mode: list
/// </summary>
public class AzurermExpressRoutePortLink2Block : TerraformBlock
{
    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AdminEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("admin_enabled");
        set => WithProperty("admin_enabled", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorType
    {
        get => GetProperty<TerraformProperty<string>>("connector_type");
        set => WithProperty("connector_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        get => GetProperty<TerraformProperty<string>>("interface_name");
        set => WithProperty("interface_name", value);
    }

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCakKeyvaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("macsec_cak_keyvault_secret_id");
        set => WithProperty("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCipher
    {
        get => GetProperty<TerraformProperty<string>>("macsec_cipher");
        set => WithProperty("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCknKeyvaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("macsec_ckn_keyvault_secret_id");
        set => WithProperty("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MacsecSciEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("macsec_sci_enabled");
        set => WithProperty("macsec_sci_enabled", value);
    }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    public TerraformProperty<string>? PatchPanelId
    {
        get => GetProperty<TerraformProperty<string>>("patch_panel_id");
        set => WithProperty("patch_panel_id", value);
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformProperty<string>? RackId
    {
        get => GetProperty<TerraformProperty<string>>("rack_id");
        set => WithProperty("rack_id", value);
    }

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    public TerraformProperty<string>? RouterName
    {
        get => GetProperty<TerraformProperty<string>>("router_name");
        set => WithProperty("router_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExpressRoutePortTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_express_route_port resource.
/// </summary>
public class AzurermExpressRoutePort : TerraformResource
{
    public AzurermExpressRoutePort(string name) : base("azurerm_express_route_port", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ethertype");
        this.DeclareOutput("guid");
        this.DeclareOutput("mtu");
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthInGbps is required")]
    public required TerraformProperty<double> BandwidthInGbps
    {
        get => GetProperty<TerraformProperty<double>>("bandwidth_in_gbps");
        set => this.WithProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    public TerraformProperty<string>? BillingType
    {
        get => GetProperty<TerraformProperty<string>>("billing_type");
        set => this.WithProperty("billing_type", value);
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    public required TerraformProperty<string> Encapsulation
    {
        get => GetProperty<TerraformProperty<string>>("encapsulation");
        set => this.WithProperty("encapsulation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    public required TerraformProperty<string> PeeringLocation
    {
        get => GetProperty<TerraformProperty<string>>("peering_location");
        set => this.WithProperty("peering_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermExpressRoutePortIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermExpressRoutePortIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for link1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    public List<AzurermExpressRoutePortLink1Block>? Link1
    {
        get => GetProperty<List<AzurermExpressRoutePortLink1Block>>("link1");
        set => this.WithProperty("link1", value);
    }

    /// <summary>
    /// Block for link2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    public List<AzurermExpressRoutePortLink2Block>? Link2
    {
        get => GetProperty<List<AzurermExpressRoutePortLink2Block>>("link2");
        set => this.WithProperty("link2", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRoutePortTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExpressRoutePortTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The ethertype attribute.
    /// </summary>
    public TerraformExpression Ethertype => this["ethertype"];

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformExpression Mtu => this["mtu"];

}
