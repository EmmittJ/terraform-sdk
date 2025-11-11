using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationTemplateDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The application template&#39;s ID
    /// </summary>
    [TerraformPropertyName("template_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TemplateId { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// List of categories for this templated application
    /// </summary>
    [TerraformPropertyName("categories")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Categories => new TerraformReference(this, "categories");

    /// <summary>
    /// Home page URL of the templated application
    /// </summary>
    [TerraformPropertyName("homepage_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomepageUrl => new TerraformReference(this, "homepage_url");

    /// <summary>
    /// URL to retrieve the logo for this templated application
    /// </summary>
    [TerraformPropertyName("logo_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LogoUrl => new TerraformReference(this, "logo_url");

    /// <summary>
    /// Name of the publisher for this templated application
    /// </summary>
    [TerraformPropertyName("publisher")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Publisher => new TerraformReference(this, "publisher");

    /// <summary>
    /// The provisioning modes supported by this templated application
    /// </summary>
    [TerraformPropertyName("supported_provisioning_types")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedProvisioningTypes => new TerraformReference(this, "supported_provisioning_types");

    /// <summary>
    /// The single sign on modes supported by this templated application
    /// </summary>
    [TerraformPropertyName("supported_single_sign_on_modes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> SupportedSingleSignOnModes => new TerraformReference(this, "supported_single_sign_on_modes");

}
