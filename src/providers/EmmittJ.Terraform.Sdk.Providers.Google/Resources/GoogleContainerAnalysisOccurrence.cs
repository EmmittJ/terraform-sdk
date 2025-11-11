using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAnalysisOccurrenceAttestationBlock : TerraformBlockBase
{
    /// <summary>
    /// The serialized payload that is verified by one or
    /// more signatures. A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SerializedPayload is required")]
    [TerraformProperty("serialized_payload")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SerializedPayload { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContainerAnalysisOccurrenceTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_container_analysis_occurrence resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContainerAnalysisOccurrence : TerraformResource
{
    public GoogleContainerAnalysisOccurrence(string name) : base("google_container_analysis_occurrence", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The analysis note associated with this occurrence, in the form of
    /// projects/[PROJECT]/notes/[NOTE_ID]. This field can be used as a
    /// filter in list requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoteName is required")]
    [TerraformProperty("note_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NoteName { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A description of actions that can be taken to remedy the note.
    /// </summary>
    [TerraformProperty("remediation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Remediation { get; set; }

    /// <summary>
    /// Required. Immutable. A URI that represents the resource for which
    /// the occurrence applies. For example,
    /// https://gcr.io/project/image@sha256:123abc for a Docker image.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceUri is required")]
    [TerraformProperty("resource_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceUri { get; set; }

    /// <summary>
    /// Block for attestation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attestation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Attestation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attestation block(s) allowed")]
    [TerraformProperty("attestation")]
    public partial TerraformList<TerraformBlock<GoogleContainerAnalysisOccurrenceAttestationBlock>>? Attestation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleContainerAnalysisOccurrenceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The note kind which explicitly denotes which of the occurrence
    /// details are specified. This field can be used as a filter in list
    /// requests.
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The name of the occurrence.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
