using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_service.
/// </summary>
public class GoogleProjectServiceDataSource : TerraformDataSource
{
    public GoogleProjectServiceDataSource(string name) : base("google_project_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    [TerraformPropertyName("disable_dependent_services")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableDependentServices => new TerraformReference(this, "disable_dependent_services");

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    [TerraformPropertyName("disable_on_destroy")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DisableOnDestroy => new TerraformReference(this, "disable_on_destroy");

}
