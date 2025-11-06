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
    public string? CdnFrontdoorProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cdn_frontdoor_profile_id")?.Value;
        set => this.WithProperty("cdn_frontdoor_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cdn_frontdoor_profile_name attribute.
    /// </summary>
    public TerraformExpression CdnFrontdoorProfileName => this["cdn_frontdoor_profile_name"];

}
