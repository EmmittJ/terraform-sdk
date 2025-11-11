using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceAgreementDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_marketplace_agreement.
/// </summary>
public class AzurermMarketplaceAgreementDataSource : TerraformDataSource
{
    public AzurermMarketplaceAgreementDataSource(string name) : base("azurerm_marketplace_agreement", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Offer { get; set; }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformPropertyName("plan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Plan { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Publisher { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMarketplaceAgreementDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    [TerraformPropertyName("accepted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Accepted => new TerraformReference(this, "accepted");

    /// <summary>
    /// The license_text_link attribute.
    /// </summary>
    [TerraformPropertyName("license_text_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseTextLink => new TerraformReference(this, "license_text_link");

    /// <summary>
    /// The privacy_policy_link attribute.
    /// </summary>
    [TerraformPropertyName("privacy_policy_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivacyPolicyLink => new TerraformReference(this, "privacy_policy_link");

}
