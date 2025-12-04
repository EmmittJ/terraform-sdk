using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation in GoogleContainerAnalysisOccurrence.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAnalysisOccurrenceAttestationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attestation";

    /// <summary>
    /// The serialized payload that is verified by one or
    /// more signatures. A base64-encoded string.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SerializedPayload is required")]
    public required TerraformValue<string> SerializedPayload
    {
        get => GetRequiredArgument<TerraformValue<string>>("serialized_payload");
        set => SetArgument("serialized_payload", value);
    }

    /// <summary>
    /// Signatures block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Signatures is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Signatures block(s) required")]
    public required TerraformSet<GoogleContainerAnalysisOccurrenceAttestationBlockSignaturesBlock> Signatures
    {
        get => GetRequiredArgument<TerraformSet<GoogleContainerAnalysisOccurrenceAttestationBlockSignaturesBlock>>("signatures");
        set => SetArgument("signatures", value);
    }

}

/// <summary>
/// Block type for signatures in GoogleContainerAnalysisOccurrenceAttestationBlock.
/// Nesting mode: set
/// </summary>
public class GoogleContainerAnalysisOccurrenceAttestationBlockSignaturesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signatures";

    /// <summary>
    /// The identifier for the public key that verifies this
    /// signature. MUST be an RFC3986 conformant
    /// URI. * When possible, the key id should be an
    /// immutable reference, such as a cryptographic digest.
    /// Examples of valid values:
    /// 
    /// * OpenPGP V4 public key fingerprint. See https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr
    ///   for more details on this scheme.
    ///     * &#39;openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA&#39;
    /// * RFC6920 digest-named SubjectPublicKeyInfo (digest of the DER serialization):
    ///     * &amp;quot;ni:///sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKeyId is required")]
    public required TerraformValue<string> PublicKeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("public_key_id");
        set => SetArgument("public_key_id", value);
    }

    /// <summary>
    /// The content of the signature, an opaque bytestring.
    /// The payload that this signature verifies MUST be
    /// unambiguously provided with the Signature during
    /// verification. A wrapper message might provide the
    /// payload explicitly. Alternatively, a message might
    /// have a canonical serialization that can always be
    /// unambiguously computed to derive the payload.
    /// </summary>
    public TerraformValue<string>? Signature
    {
        get => GetArgument<TerraformValue<string>>("signature");
        set => SetArgument("signature", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAnalysisOccurrence.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAnalysisOccurrenceTimeoutsBlock : TerraformBlock
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
/// Represents a google_container_analysis_occurrence Terraform resource.
/// Manages a google_container_analysis_occurrence resource.
/// </summary>
public partial class GoogleContainerAnalysisOccurrence(string name) : TerraformResource("google_container_analysis_occurrence", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The analysis note associated with this occurrence, in the form of
    /// projects/[PROJECT]/notes/[NOTE_ID]. This field can be used as a
    /// filter in list requests.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NoteName is required")]
    public required TerraformValue<string> NoteName
    {
        get => GetRequiredArgument<TerraformValue<string>>("note_name");
        set => SetArgument("note_name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// A description of actions that can be taken to remedy the note.
    /// </summary>
    public TerraformValue<string>? Remediation
    {
        get => GetArgument<TerraformValue<string>>("remediation");
        set => SetArgument("remediation", value);
    }

    /// <summary>
    /// Required. Immutable. A URI that represents the resource for which
    /// the occurrence applies. For example,
    /// https://gcr.io/project/image@sha256:123abc for a Docker image.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceUri is required")]
    public required TerraformValue<string> ResourceUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_uri");
        set => SetArgument("resource_uri", value);
    }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The note kind which explicitly denotes which of the occurrence
    /// details are specified. This field can be used as a filter in list
    /// requests.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The name of the occurrence.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Attestation block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attestation is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Attestation block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attestation block(s) allowed")]
    public required TerraformList<GoogleContainerAnalysisOccurrenceAttestationBlock> Attestation
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAnalysisOccurrenceAttestationBlock>>("attestation");
        set => SetArgument("attestation", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAnalysisOccurrenceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAnalysisOccurrenceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
