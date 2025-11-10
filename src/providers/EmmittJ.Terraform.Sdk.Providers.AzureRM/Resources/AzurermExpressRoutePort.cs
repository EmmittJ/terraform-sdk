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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("admin_enabled", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorType
    {
        set => SetProperty("connector_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        set => SetProperty("interface_name", value);
    }

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCakKeyvaultSecretId
    {
        set => SetProperty("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCipher
    {
        set => SetProperty("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCknKeyvaultSecretId
    {
        set => SetProperty("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MacsecSciEnabled
    {
        set => SetProperty("macsec_sci_enabled", value);
    }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    public TerraformProperty<string>? PatchPanelId
    {
        set => SetProperty("patch_panel_id", value);
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformProperty<string>? RackId
    {
        set => SetProperty("rack_id", value);
    }

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    public TerraformProperty<string>? RouterName
    {
        set => SetProperty("router_name", value);
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
        set => SetProperty("admin_enabled", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectorType
    {
        set => SetProperty("connector_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The interface_name attribute.
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        set => SetProperty("interface_name", value);
    }

    /// <summary>
    /// The macsec_cak_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCakKeyvaultSecretId
    {
        set => SetProperty("macsec_cak_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_cipher attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCipher
    {
        set => SetProperty("macsec_cipher", value);
    }

    /// <summary>
    /// The macsec_ckn_keyvault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? MacsecCknKeyvaultSecretId
    {
        set => SetProperty("macsec_ckn_keyvault_secret_id", value);
    }

    /// <summary>
    /// The macsec_sci_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MacsecSciEnabled
    {
        set => SetProperty("macsec_sci_enabled", value);
    }

    /// <summary>
    /// The patch_panel_id attribute.
    /// </summary>
    public TerraformProperty<string>? PatchPanelId
    {
        set => SetProperty("patch_panel_id", value);
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformProperty<string>? RackId
    {
        set => SetProperty("rack_id", value);
    }

    /// <summary>
    /// The router_name attribute.
    /// </summary>
    public TerraformProperty<string>? RouterName
    {
        set => SetProperty("router_name", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ethertype");
        SetOutput("guid");
        SetOutput("mtu");
        SetOutput("bandwidth_in_gbps");
        SetOutput("billing_type");
        SetOutput("encapsulation");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("peering_location");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The bandwidth_in_gbps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BandwidthInGbps is required")]
    public required TerraformProperty<double> BandwidthInGbps
    {
        get => GetRequiredOutput<TerraformProperty<double>>("bandwidth_in_gbps");
        set => SetProperty("bandwidth_in_gbps", value);
    }

    /// <summary>
    /// The billing_type attribute.
    /// </summary>
    public TerraformProperty<string> BillingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("billing_type");
        set => SetProperty("billing_type", value);
    }

    /// <summary>
    /// The encapsulation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Encapsulation is required")]
    public required TerraformProperty<string> Encapsulation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encapsulation");
        set => SetProperty("encapsulation", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The peering_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PeeringLocation is required")]
    public required TerraformProperty<string> PeeringLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering_location");
        set => SetProperty("peering_location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermExpressRoutePortIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for link1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link1 block(s) allowed")]
    public List<AzurermExpressRoutePortLink1Block>? Link1
    {
        set => SetProperty("link1", value);
    }

    /// <summary>
    /// Block for link2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Link2 block(s) allowed")]
    public List<AzurermExpressRoutePortLink2Block>? Link2
    {
        set => SetProperty("link2", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExpressRoutePortTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
