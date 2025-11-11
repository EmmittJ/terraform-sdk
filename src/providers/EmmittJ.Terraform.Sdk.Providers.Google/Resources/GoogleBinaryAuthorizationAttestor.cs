using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority_note in .
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock
{

    /// <summary>
    /// The resource name of a ATTESTATION_AUTHORITY Note, created by the
    /// user. If the Note is in a different project from the Attestor, it
    /// should be specified in the format &#39;projects/*/notes/*&#39; (or the legacy
    /// &#39;providers/*/notes/*&#39;). This field may not be updated.
    /// An attestation by this attestor is stored as a Container Analysis
    /// ATTESTATION_AUTHORITY Occurrence that names a container image
    /// and that links to this Note.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoteReference is required")]
    [TerraformPropertyName("note_reference")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> NoteReference { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBinaryAuthorizationAttestorTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_binary_authorization_attestor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBinaryAuthorizationAttestor : TerraformResource
{
    public GoogleBinaryAuthorizationAttestor(string name) : base("google_binary_authorization_attestor", name)
    {
    }

    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for attestation_authority_note.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthorityNote is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthorityNote block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthorityNote block(s) allowed")]
    [TerraformPropertyName("attestation_authority_note")]
    public TerraformList<TerraformBlock<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock>>? AttestationAuthorityNote { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBinaryAuthorizationAttestorTimeoutsBlock>? Timeouts { get; set; }

}
