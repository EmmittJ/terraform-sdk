using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationTemplateDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_application_template.
/// </summary>
public partial class AzureadApplicationTemplateDataSource : TerraformDataSource
{
    public AzureadApplicationTemplateDataSource(string name) : base("azuread_application_template", name)
    {
    }

    /// <summary>
    /// The display name for the application template
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The application template&#39;s ID
    /// </summary>
    [TerraformProperty("template_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadApplicationTemplateDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// List of categories for this templated application
    /// </summary>
    [TerraformProperty("categories")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Categories { get; }

    /// <summary>
    /// Home page URL of the templated application
    /// </summary>
    [TerraformProperty("homepage_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HomepageUrl { get; }

    /// <summary>
    /// URL to retrieve the logo for this templated application
    /// </summary>
    [TerraformProperty("logo_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LogoUrl { get; }

    /// <summary>
    /// Name of the publisher for this templated application
    /// </summary>
    [TerraformProperty("publisher")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Publisher { get; }

    /// <summary>
    /// The provisioning modes supported by this templated application
    /// </summary>
    [TerraformProperty("supported_provisioning_types")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedProvisioningTypes { get; }

    /// <summary>
    /// The single sign on modes supported by this templated application
    /// </summary>
    [TerraformProperty("supported_single_sign_on_modes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> SupportedSingleSignOnModes { get; }

}
