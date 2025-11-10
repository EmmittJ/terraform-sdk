using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cdn_frontdoor_custom_domain_association resource.
/// </summary>
public class AzurermCdnFrontdoorCustomDomainAssociation : TerraformResource
{
    public AzurermCdnFrontdoorCustomDomainAssociation(string name) : base("azurerm_cdn_frontdoor_custom_domain_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cdn_frontdoor_custom_domain_id");
        SetOutput("cdn_frontdoor_route_ids");
        SetOutput("id");
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorCustomDomainId is required")]
    public required TerraformProperty<string> CdnFrontdoorCustomDomainId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_custom_domain_id");
        set => SetProperty("cdn_frontdoor_custom_domain_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_route_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRouteIds is required")]
    public List<TerraformProperty<string>> CdnFrontdoorRouteIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cdn_frontdoor_route_ids");
        set => SetProperty("cdn_frontdoor_route_ids", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
