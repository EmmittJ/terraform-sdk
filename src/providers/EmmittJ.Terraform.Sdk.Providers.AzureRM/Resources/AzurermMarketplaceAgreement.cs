using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceAgreementTimeoutsBlock : TerraformBlock
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

}

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
    public AzurermMarketplaceAgreementTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
