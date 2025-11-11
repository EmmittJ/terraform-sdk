using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadApplicationFromTemplateTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_from_template resource.
/// </summary>
public partial class AzureadApplicationFromTemplate : TerraformResource
{
    public AzureadApplicationFromTemplate(string name) : base("azuread_application_from_template", name)
    {
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The UUID of the template to instantiate for this application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformProperty("template_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadApplicationFromTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource ID for this application
    /// </summary>
    [TerraformProperty("application_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApplicationId { get; }

    /// <summary>
    /// The object ID for this application
    /// </summary>
    [TerraformProperty("application_object_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ApplicationObjectId { get; }

    /// <summary>
    /// The resource ID for this service principal
    /// </summary>
    [TerraformProperty("service_principal_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServicePrincipalId { get; }

    /// <summary>
    /// The object ID for this service principal
    /// </summary>
    [TerraformProperty("service_principal_object_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServicePrincipalObjectId { get; }

}
