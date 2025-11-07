using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorCustomDomainId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_custom_domain_id");
        set => this.WithProperty("cdn_frontdoor_custom_domain_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_route_ids attribute.
    /// </summary>
    public TerraformProperty<List<string>>? CdnFrontdoorRouteIds
    {
        get => GetProperty<TerraformProperty<List<string>>>("cdn_frontdoor_route_ids");
        set => this.WithProperty("cdn_frontdoor_route_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
