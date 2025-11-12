using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for deidentify_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock() : TerraformBlock("deidentify_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_loss_prevention_deidentify_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataLossPreventionDeidentifyTemplate : TerraformResource
{
    public GoogleDataLossPreventionDeidentifyTemplate(string name) : base("google_data_loss_prevention_deidentify_template", name)
    {
    }

    /// <summary>
    /// A description of the template.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User set display name of the template.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent of the template in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [TerraformProperty("template_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for deidentify_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeidentifyConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DeidentifyConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeidentifyConfig block(s) allowed")]
    [TerraformProperty("deidentify_config")]
    public required TerraformList<GoogleDataLossPreventionDeidentifyTemplateDeidentifyConfigBlock> DeidentifyConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleDataLossPreventionDeidentifyTemplateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The creation timestamp of an deidentifyTemplate. Set by the server.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The resource name of the template. Set by the server.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The last update timestamp of an deidentifyTemplate. Set by the server.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
