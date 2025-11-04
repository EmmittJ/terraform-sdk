using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_marketplace_agreement resource.
/// </summary>
public class AzurermMarketplaceAgreement : TerraformResource
{
    public AzurermMarketplaceAgreement(string name) : base("azurerm_marketplace_agreement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("license_text_link");
        this.DeclareOutput("privacy_policy_link");
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
    /// The offer attribute.
    /// </summary>
    public string? Offer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offer")?.Value;
        set => this.WithProperty("offer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public string? Plan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan")?.Value;
        set => this.WithProperty("plan", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public string? Publisher
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher")?.Value;
        set => this.WithProperty("publisher", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_text_link attribute.
    /// </summary>
    public TerraformExpression LicenseTextLink => this["license_text_link"];

    /// <summary>
    /// The privacy_policy_link attribute.
    /// </summary>
    public TerraformExpression PrivacyPolicyLink => this["privacy_policy_link"];

}
