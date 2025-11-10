using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTemplateDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_application_template.
/// </summary>
public class AzureadApplicationTemplateDataSource : TerraformDataSource
{
    public AzureadApplicationTemplateDataSource(string name) : base("azuread_application_template", name)
    {
    }

    /// <summary>
    /// The display name for the application template
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DisplayName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The application template&#39;s ID
    /// </summary>
    [TerraformPropertyName("template_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TemplateId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// List of categories for this templated application
    /// </summary>
    [TerraformPropertyName("categories")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Categories => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "categories");

    /// <summary>
    /// Home page URL of the templated application
    /// </summary>
    [TerraformPropertyName("homepage_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HomepageUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "homepage_url");

    /// <summary>
    /// URL to retrieve the logo for this templated application
    /// </summary>
    [TerraformPropertyName("logo_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LogoUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "logo_url");

    /// <summary>
    /// Name of the publisher for this templated application
    /// </summary>
    [TerraformPropertyName("publisher")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Publisher => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "publisher");

    /// <summary>
    /// The provisioning modes supported by this templated application
    /// </summary>
    [TerraformPropertyName("supported_provisioning_types")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedProvisioningTypes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_provisioning_types");

    /// <summary>
    /// The single sign on modes supported by this templated application
    /// </summary>
    [TerraformPropertyName("supported_single_sign_on_modes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> SupportedSingleSignOnModes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "supported_single_sign_on_modes");

}
