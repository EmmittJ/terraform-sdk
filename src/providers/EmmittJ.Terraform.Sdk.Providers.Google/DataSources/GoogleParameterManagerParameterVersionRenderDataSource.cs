using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter_version_render.
/// </summary>
public class GoogleParameterManagerParameterVersionRenderDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterVersionRenderDataSource(string name) : base("google_parameter_manager_parameter_version_render", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformPropertyName("parameter")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parameter { get; set; }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    [TerraformPropertyName("parameter_version_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParameterVersionId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Disabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disabled");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    [TerraformPropertyName("parameter_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParameterData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parameter_data");

    /// <summary>
    /// The rendered_parameter_data attribute.
    /// </summary>
    [TerraformPropertyName("rendered_parameter_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RenderedParameterData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rendered_parameter_data");

}
