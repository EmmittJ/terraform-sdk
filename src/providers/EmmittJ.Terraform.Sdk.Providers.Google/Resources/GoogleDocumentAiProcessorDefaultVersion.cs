using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_document_ai_processor_default_version resource.
/// </summary>
public partial class GoogleDocumentAiProcessorDefaultVersion : TerraformResource
{
    public GoogleDocumentAiProcessorDefaultVersion(string name) : base("google_document_ai_processor_default_version", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The processor to set the version on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Processor is required")]
    [TerraformProperty("processor")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Processor { get; set; }

    /// <summary>
    /// The version to set. Using &#39;stable&#39; or &#39;rc&#39; will cause the API to return the latest version in that release channel.
    /// Apply &#39;lifecycle.ignore_changes&#39; to the &#39;version&#39; field to suppress this diff.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDocumentAiProcessorDefaultVersionTimeoutsBlock>? Timeouts { get; set; }

}
