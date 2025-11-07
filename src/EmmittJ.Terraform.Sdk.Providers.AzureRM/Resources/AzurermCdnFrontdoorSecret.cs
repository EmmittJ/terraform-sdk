using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cdn_frontdoor_secret resource.
/// </summary>
public class AzurermCdnFrontdoorSecret : TerraformResource
{
    public AzurermCdnFrontdoorSecret(string name) : base("azurerm_cdn_frontdoor_secret", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cdn_frontdoor_profile_name");
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
    /// The cdn_frontdoor_profile_name attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorProfileName => this["cdn_frontdoor_profile_name"];

}
