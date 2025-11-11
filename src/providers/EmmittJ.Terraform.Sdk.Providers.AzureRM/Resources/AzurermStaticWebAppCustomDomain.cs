using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStaticWebAppCustomDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_static_web_app_custom_domain resource.
/// </summary>
public partial class AzurermStaticWebAppCustomDomain : TerraformResource
{
    public AzurermStaticWebAppCustomDomain(string name) : base("azurerm_static_web_app_custom_domain", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The static_web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StaticWebAppId is required")]
    [TerraformProperty("static_web_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StaticWebAppId { get; set; }

    /// <summary>
    /// The validation_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValidationType is required")]
    [TerraformProperty("validation_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ValidationType { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermStaticWebAppCustomDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The validation_token attribute.
    /// </summary>
    [TerraformProperty("validation_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ValidationToken { get; }

}
