using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationFromTemplateTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azuread_application_from_template resource.
/// </summary>
public class AzureadApplicationFromTemplate : TerraformResource
{
    public AzureadApplicationFromTemplate(string name) : base("azuread_application_from_template", name)
    {
    }

    /// <summary>
    /// The display name for the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The UUID of the template to instantiate for this application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformPropertyName("template_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationFromTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource ID for this application
    /// </summary>
    [TerraformPropertyName("application_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationId => new TerraformReference(this, "application_id");

    /// <summary>
    /// The object ID for this application
    /// </summary>
    [TerraformPropertyName("application_object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationObjectId => new TerraformReference(this, "application_object_id");

    /// <summary>
    /// The resource ID for this service principal
    /// </summary>
    [TerraformPropertyName("service_principal_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServicePrincipalId => new TerraformReference(this, "service_principal_id");

    /// <summary>
    /// The object ID for this service principal
    /// </summary>
    [TerraformPropertyName("service_principal_object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServicePrincipalObjectId => new TerraformReference(this, "service_principal_object_id");

}
