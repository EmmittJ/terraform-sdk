using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority_note in GoogleBinaryAuthorizationAttestor.
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attestation_authority_note";

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
    public TerraformValue<string> DelegationServiceAccountEmail
        => AsReference("delegation_service_account_email");

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
    public required TerraformValue<string> NoteReference
    {
        get => GetArgument<TerraformValue<string>>("note_reference");
        set => SetArgument("note_reference", value);
    }

    /// <summary>
    /// PublicKeys block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlock>? PublicKeys
    {
        get => GetArgument<TerraformList<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlock>>("public_keys");
        set => SetArgument("public_keys", value);
    }

}

/// <summary>
/// Block type for public_keys in GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_keys";

    /// <summary>
    /// ASCII-armored representation of a PGP public key, as the
    /// entire output by the command
    /// &#39;gpg --export --armor foo@example.com&#39; (either LF or CRLF
    /// line endings). When using this field, id should be left
    /// blank. The BinAuthz API handlers will calculate the ID
    /// and fill it in automatically. BinAuthz computes this ID
    /// as the OpenPGP RFC4880 V4 fingerprint, represented as
    /// upper-case hex. If id is provided by the caller, it will
    /// be overwritten by the API-calculated ID.
    /// </summary>
    public TerraformValue<string>? AsciiArmoredPgpPublicKey
    {
        get => GetArgument<TerraformValue<string>>("ascii_armored_pgp_public_key");
        set => SetArgument("ascii_armored_pgp_public_key", value);
    }

    /// <summary>
    /// A descriptive comment. This field may be updated.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => GetArgument<TerraformValue<string>>("comment");
        set => SetArgument("comment", value);
    }

    /// <summary>
    /// The ID of this public key. Signatures verified by BinAuthz
    /// must include the ID of the public key that can be used to
    /// verify them, and that ID must match the contents of this
    /// field exactly. Additional restrictions on this field can
    /// be imposed based on which public key type is encapsulated.
    /// See the documentation on publicKey cases below for details.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// PkixPublicKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PkixPublicKey block(s) allowed")]
    public TerraformList<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlockPkixPublicKeyBlock>? PkixPublicKey
    {
        get => GetArgument<TerraformList<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlockPkixPublicKeyBlock>>("pkix_public_key");
        set => SetArgument("pkix_public_key", value);
    }

}

/// <summary>
/// Block type for pkix_public_key in GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlockPublicKeysBlockPkixPublicKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pkix_public_key";

    /// <summary>
    /// A PEM-encoded public key, as described in
    /// &#39;https://tools.ietf.org/html/rfc7468#section-13&#39;
    /// </summary>
    public TerraformValue<string>? PublicKeyPem
    {
        get => GetArgument<TerraformValue<string>>("public_key_pem");
        set => SetArgument("public_key_pem", value);
    }

    /// <summary>
    /// The signature algorithm used to verify a message against
    /// a signature using this key. These signature algorithm must
    /// match the structure and any object identifiers encoded in
    /// publicKeyPem (i.e. this algorithm must match that of the
    /// public key).
    /// </summary>
    public TerraformValue<string>? SignatureAlgorithm
    {
        get => GetArgument<TerraformValue<string>>("signature_algorithm");
        set => SetArgument("signature_algorithm", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBinaryAuthorizationAttestor.
/// Nesting mode: single
/// </summary>
public class GoogleBinaryAuthorizationAttestorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_binary_authorization_attestor Terraform resource.
/// Manages a google_binary_authorization_attestor resource.
/// </summary>
public partial class GoogleBinaryAuthorizationAttestor(string name) : TerraformResource("google_binary_authorization_attestor", name)
{
    /// <summary>
    /// A descriptive comment. This field may be updated. The field may be
    /// displayed in chooser dialogs.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// AttestationAuthorityNote block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthorityNote is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthorityNote block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthorityNote block(s) allowed")]
    public required TerraformList<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock> AttestationAuthorityNote
    {
        get => GetRequiredArgument<TerraformList<GoogleBinaryAuthorizationAttestorAttestationAuthorityNoteBlock>>("attestation_authority_note");
        set => SetArgument("attestation_authority_note", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBinaryAuthorizationAttestorTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBinaryAuthorizationAttestorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
