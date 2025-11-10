using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationFromTemplateTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The UUID of the template to instantiate for this application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateId is required")]
    [TerraformPropertyName("template_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TemplateId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadApplicationFromTemplateTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The resource ID for this application
    /// </summary>
    [TerraformPropertyName("application_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_id");

    /// <summary>
    /// The object ID for this application
    /// </summary>
    [TerraformPropertyName("application_object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApplicationObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "application_object_id");

    /// <summary>
    /// The resource ID for this service principal
    /// </summary>
    [TerraformPropertyName("service_principal_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServicePrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_principal_id");

    /// <summary>
    /// The object ID for this service principal
    /// </summary>
    [TerraformPropertyName("service_principal_object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServicePrincipalObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_principal_object_id");

}
