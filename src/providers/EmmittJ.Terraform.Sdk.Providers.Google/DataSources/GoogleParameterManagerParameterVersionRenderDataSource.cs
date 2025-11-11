using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_parameter_manager_parameter_version_render.
/// </summary>
public partial class GoogleParameterManagerParameterVersionRenderDataSource : TerraformDataSource
{
    public GoogleParameterManagerParameterVersionRenderDataSource(string name) : base("google_parameter_manager_parameter_version_render", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [TerraformProperty("parameter")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parameter { get; set; }

    /// <summary>
    /// The parameter_version_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterVersionId is required")]
    [TerraformProperty("parameter_version_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ParameterVersionId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Disabled { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The parameter_data attribute.
    /// </summary>
    [TerraformProperty("parameter_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParameterData { get; }

    /// <summary>
    /// The rendered_parameter_data attribute.
    /// </summary>
    [TerraformProperty("rendered_parameter_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RenderedParameterData { get; }

}
