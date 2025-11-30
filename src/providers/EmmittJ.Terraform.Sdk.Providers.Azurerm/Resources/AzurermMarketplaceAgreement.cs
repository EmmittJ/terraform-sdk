using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMarketplaceAgreement.
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceAgreementTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_marketplace_agreement Terraform resource.
/// Manages a azurerm_marketplace_agreement resource.
/// </summary>
public partial class AzurermMarketplaceAgreement(string name) : TerraformResource("azurerm_marketplace_agreement", name)
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
    public AzurermMarketplaceAgreementTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMarketplaceAgreementTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
