using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAnalysisNoteAttestationAuthorityBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for related_url in .
/// Nesting mode: set
/// </summary>
public class GoogleContainerAnalysisNoteRelatedUrlBlock : ITerraformBlock
{
    /// <summary>
    /// Label to describe usage of the URL
    /// </summary>
    [TerraformPropertyName("label")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Label { get; set; }

    /// <summary>
    /// Specific URL associated with the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAnalysisNoteTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_container_analysis_note resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerAnalysisNote : TerraformResource
{
    public GoogleContainerAnalysisNote(string name) : base("google_container_analysis_note", name)
    {
    }

    /// <summary>
    /// Time of expiration for this note. Leave empty if note does not expire.
    /// </summary>
    [TerraformPropertyName("expiration_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpirationTime { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A detailed description of the note
    /// </summary>
    [TerraformPropertyName("long_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LongDescription { get; set; }

    /// <summary>
    /// The name of the note.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Names of other notes related to this note.
    /// </summary>
    [TerraformPropertyName("related_note_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RelatedNoteNames { get; set; }

    /// <summary>
    /// A one sentence description of the note.
    /// </summary>
    [TerraformPropertyName("short_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ShortDescription { get; set; }

    /// <summary>
    /// Block for attestation_authority.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthority is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthority block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthority block(s) allowed")]
    [TerraformPropertyName("attestation_authority")]
    public TerraformList<TerraformBlock<GoogleContainerAnalysisNoteAttestationAuthorityBlock>>? AttestationAuthority { get; set; } = new();

    /// <summary>
    /// Block for related_url.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("related_url")]
    public TerraformSet<TerraformBlock<GoogleContainerAnalysisNoteRelatedUrlBlock>>? RelatedUrl { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleContainerAnalysisNoteTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time this note was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The type of analysis this note describes
    /// </summary>
    [TerraformPropertyName("kind")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Kind => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kind");

    /// <summary>
    /// The time this note was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
