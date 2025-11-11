using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority in .
/// Nesting mode: list
/// </summary>
public partial class GoogleContainerAnalysisNoteAttestationAuthorityBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for related_url in .
/// Nesting mode: set
/// </summary>
public partial class GoogleContainerAnalysisNoteRelatedUrlBlock : TerraformBlockBase
{
    /// <summary>
    /// Label to describe usage of the URL
    /// </summary>
    [TerraformProperty("label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Label { get; set; }

    /// <summary>
    /// Specific URL associated with the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleContainerAnalysisNoteTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_container_analysis_note resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleContainerAnalysisNote : TerraformResource
{
    public GoogleContainerAnalysisNote(string name) : base("google_container_analysis_note", name)
    {
    }

    /// <summary>
    /// Time of expiration for this note. Leave empty if note does not expire.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExpirationTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A detailed description of the note
    /// </summary>
    [TerraformProperty("long_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LongDescription { get; set; }

    /// <summary>
    /// The name of the note.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Names of other notes related to this note.
    /// </summary>
    [TerraformProperty("related_note_names")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RelatedNoteNames { get; set; }

    /// <summary>
    /// A one sentence description of the note.
    /// </summary>
    [TerraformProperty("short_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ShortDescription { get; set; }

    /// <summary>
    /// Block for attestation_authority.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthority is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthority block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthority block(s) allowed")]
    [TerraformProperty("attestation_authority")]
    public partial TerraformList<TerraformBlock<GoogleContainerAnalysisNoteAttestationAuthorityBlock>>? AttestationAuthority { get; set; }

    /// <summary>
    /// Block for related_url.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("related_url")]
    public partial TerraformSet<TerraformBlock<GoogleContainerAnalysisNoteRelatedUrlBlock>>? RelatedUrl { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleContainerAnalysisNoteTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time this note was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The type of analysis this note describes
    /// </summary>
    [TerraformProperty("kind")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Kind { get; }

    /// <summary>
    /// The time this note was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
