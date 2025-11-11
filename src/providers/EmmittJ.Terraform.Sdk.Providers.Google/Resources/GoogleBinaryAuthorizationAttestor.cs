using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority_note in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock : TerraformBlockBase
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
    [TerraformProperty("note_reference")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NoteReference { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBinaryAuthorizationAttestorTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_binary_authorization_attestor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBinaryAuthorizationAttestor : TerraformResource
{
    public GoogleBinaryAuthorizationAttestor(string name) : base("google_binary_authorization_attestor", name)
    {
    }

    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource name.
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
    /// Block for attestation_authority_note.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthorityNote is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthorityNote block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthorityNote block(s) allowed")]
    [TerraformProperty("attestation_authority_note")]
    public partial TerraformList<TerraformBlock<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock>>? AttestationAuthorityNote { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleBinaryAuthorizationAttestorTimeoutsBlock>? Timeouts { get; set; }

}
