using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceAgreementDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_marketplace_agreement.
/// </summary>
public class AzurermMarketplaceAgreementDataSource : TerraformDataSource
{
    public AzurermMarketplaceAgreementDataSource(string name) : base("azurerm_marketplace_agreement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accepted");
        this.DeclareOutput("license_text_link");
        this.DeclareOutput("privacy_policy_link");
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
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        get => GetProperty<TerraformProperty<string>>("offer");
        set => this.WithProperty("offer", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        get => GetProperty<TerraformProperty<string>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => this.WithProperty("publisher", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMarketplaceAgreementDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMarketplaceAgreementDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    public TerraformExpression Accepted => this["accepted"];

    /// <summary>
    /// The license_text_link attribute.
    /// </summary>
    public TerraformExpression LicenseTextLink => this["license_text_link"];

    /// <summary>
    /// The privacy_policy_link attribute.
    /// </summary>
    public TerraformExpression PrivacyPolicyLink => this["privacy_policy_link"];

}
