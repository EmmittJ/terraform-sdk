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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Offer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("offer");
        set => this.WithProperty("offer", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Plan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Publisher
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher");
        set => this.WithProperty("publisher", value);
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
