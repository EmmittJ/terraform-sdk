using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for inspect_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataLossPreventionInspectTemplateInspectConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// List of options defining data content to scan. If empty, text, images, and other content will be included. Possible values: [&amp;quot;CONTENT_TEXT&amp;quot;, &amp;quot;CONTENT_IMAGE&amp;quot;]
    /// </summary>
    [TerraformProperty("content_options")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? ContentOptions { get; set; }

    /// <summary>
    /// When true, excludes type information of the findings.
    /// </summary>
    [TerraformProperty("exclude_info_types")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ExcludeInfoTypes { get; set; }

    /// <summary>
    /// When true, a contextual quote from the data that triggered a finding is included in the response.
    /// </summary>
    [TerraformProperty("include_quote")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeQuote { get; set; }

    /// <summary>
    /// Only returns findings equal or above this threshold. See https://cloud.google.com/dlp/docs/likelihood for more info Default value: &amp;quot;POSSIBLE&amp;quot; Possible values: [&amp;quot;VERY_UNLIKELY&amp;quot;, &amp;quot;UNLIKELY&amp;quot;, &amp;quot;POSSIBLE&amp;quot;, &amp;quot;LIKELY&amp;quot;, &amp;quot;VERY_LIKELY&amp;quot;]
    /// </summary>
    [TerraformProperty("min_likelihood")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MinLikelihood { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataLossPreventionInspectTemplateTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_data_loss_prevention_inspect_template resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataLossPreventionInspectTemplate : TerraformResource
{
    public GoogleDataLossPreventionInspectTemplate(string name) : base("google_data_loss_prevention_inspect_template", name)
    {
    }

    /// <summary>
    /// A description of the inspect template.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// User set display name of the inspect template.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parent of the inspect template in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}&#39;
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [TerraformProperty("template_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> TemplateId { get; set; }

    /// <summary>
    /// Block for inspect_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectConfig block(s) allowed")]
    [TerraformProperty("inspect_config")]
    public TerraformList<TerraformBlock<GoogleDataLossPreventionInspectTemplateInspectConfigBlock>>? InspectConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataLossPreventionInspectTemplateTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the inspect template. Set by the server.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
