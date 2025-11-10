using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMarketplaceAgreementDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Offer is required")]
    [TerraformPropertyName("offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Offer { get; set; }

    /// <summary>
    /// The plan attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [TerraformPropertyName("plan")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Plan { get; set; }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    [TerraformPropertyName("publisher")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Publisher { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMarketplaceAgreementDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The accepted attribute.
    /// </summary>
    [TerraformPropertyName("accepted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Accepted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "accepted");

    /// <summary>
    /// The license_text_link attribute.
    /// </summary>
    [TerraformPropertyName("license_text_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseTextLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_text_link");

    /// <summary>
    /// The privacy_policy_link attribute.
    /// </summary>
    [TerraformPropertyName("privacy_policy_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivacyPolicyLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "privacy_policy_link");

}
