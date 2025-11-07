using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_frontdoor_custom_domain resource.
/// </summary>
public class AzurermCdnFrontdoorCustomDomain : TerraformResource
{
    public AzurermCdnFrontdoorCustomDomain(string name) : base("azurerm_cdn_frontdoor_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("validation_token");
    }

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? CdnFrontdoorProfileId
    {
        get => GetProperty<TerraformProperty<string>>("cdn_frontdoor_profile_id");
        set => this.WithProperty("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The dns_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? DnsZoneId
    {
        get => GetProperty<TerraformProperty<string>>("dns_zone_id");
        set => this.WithProperty("dns_zone_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => this.WithProperty("host_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    public TerraformExpression ValidationToken => this["validation_token"];

}
