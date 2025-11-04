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
    public string? CdnFrontdoorCustomDomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_custom_domain_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_custom_domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_route_ids attribute.
    /// </summary>
    public List<string>? CdnFrontdoorRouteIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("cdn_frontdoor_route_ids")?.Value;
        set => this.WithProperty("cdn_frontdoor_route_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
