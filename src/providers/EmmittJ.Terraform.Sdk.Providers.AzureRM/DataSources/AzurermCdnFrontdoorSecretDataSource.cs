using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorSecretDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_cdn_frontdoor_secret.
/// </summary>
public class AzurermCdnFrontdoorSecretDataSource : TerraformDataSource
{
    public AzurermCdnFrontdoorSecretDataSource(string name) : base("azurerm_cdn_frontdoor_secret", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformPropertyName("profile_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProfileName { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCdnFrontdoorSecretDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [TerraformPropertyName("cdn_frontdoor_profile_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CdnFrontdoorProfileId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cdn_frontdoor_profile_id");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Secret => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secret");

}
