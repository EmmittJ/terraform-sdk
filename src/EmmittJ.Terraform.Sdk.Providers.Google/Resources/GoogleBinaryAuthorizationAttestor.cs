using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority_note in .
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock : TerraformBlock
{
    /// <summary>
    /// This field will contain the service account email address that
    /// this Attestor will use as the principal when querying Container
    /// Analysis. Attestor administrators must grant this service account
    /// the IAM role needed to read attestations from the noteReference in
    /// Container Analysis (containeranalysis.notes.occurrences.viewer).
    /// This email address is fixed for the lifetime of the Attestor, but
    /// callers should not make any other assumptions about the service
    /// account email; future versions may use an email based on a
    /// different naming pattern.
    /// </summary>
    public TerraformProperty<string>? DelegationServiceAccountEmail
    {
        get => GetProperty<TerraformProperty<string>>("delegation_service_account_email");
        set => WithProperty("delegation_service_account_email", value);
    }

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
    public required TerraformProperty<string> NoteReference
    {
        get => GetProperty<TerraformProperty<string>>("note_reference");
        set => WithProperty("note_reference", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBinaryAuthorizationAttestorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_binary_authorization_attestor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBinaryAuthorizationAttestor : TerraformResource
{
    public GoogleBinaryAuthorizationAttestor(string name) : base("google_binary_authorization_attestor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for attestation_authority_note.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthorityNote block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthorityNote block(s) allowed")]
    public List<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock>? AttestationAuthorityNote
    {
        get => GetProperty<List<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock>>("attestation_authority_note");
        set => this.WithProperty("attestation_authority_note", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBinaryAuthorizationAttestorTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBinaryAuthorizationAttestorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
