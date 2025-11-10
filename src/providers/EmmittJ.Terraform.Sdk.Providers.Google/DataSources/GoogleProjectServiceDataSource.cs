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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// The disable_dependent_services attribute.
    /// </summary>
    [TerraformPropertyName("disable_dependent_services")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableDependentServices => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_dependent_services");

    /// <summary>
    /// The disable_on_destroy attribute.
    /// </summary>
    [TerraformPropertyName("disable_on_destroy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableOnDestroy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_on_destroy");

}
