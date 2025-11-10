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
        set => SetProperty("read", value);
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
        SetOutput("accepted");
        SetOutput("license_text_link");
        SetOutput("privacy_policy_link");
        SetOutput("id");
        SetOutput("offer");
        SetOutput("plan");
        SetOutput("publisher");
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
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformProperty<string> Offer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("offer");
        set => SetProperty("offer", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformProperty<string> Plan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plan");
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredOutput<TerraformProperty<string>>("publisher");
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMarketplaceAgreementDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
