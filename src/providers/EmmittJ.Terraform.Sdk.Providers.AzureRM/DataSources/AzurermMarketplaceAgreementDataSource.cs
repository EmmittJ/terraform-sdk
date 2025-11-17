using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMarketplaceAgreementDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceAgreementDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_marketplace_agreement Terraform data source.
/// Retrieves information about a azurerm_marketplace_agreement.
/// </summary>
public partial class AzurermMarketplaceAgreementDataSource(string name) : TerraformDataSource("azurerm_marketplace_agreement", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    public required TerraformValue<string> Offer
    {
        get => new TerraformReference<string>(this, "offer");
        set => SetArgument("offer", value);
    }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    public required TerraformValue<string> Plan
    {
        get => new TerraformReference<string>(this, "plan");
        set => SetArgument("plan", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformValue<string> Publisher
    {
        get => new TerraformReference<string>(this, "publisher");
        set => SetArgument("publisher", value);
    }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    public TerraformValue<bool> Accepted
    {
        get => new TerraformReference<bool>(this, "accepted");
    }

    /// <summary>
    /// The license_text_link attribute.
    /// </summary>
    public TerraformValue<string> LicenseTextLink
    {
        get => new TerraformReference<string>(this, "license_text_link");
    }

    /// <summary>
    /// The privacy_policy_link attribute.
    /// </summary>
    public TerraformValue<string> PrivacyPolicyLink
    {
        get => new TerraformReference<string>(this, "privacy_policy_link");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMarketplaceAgreementDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMarketplaceAgreementDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
