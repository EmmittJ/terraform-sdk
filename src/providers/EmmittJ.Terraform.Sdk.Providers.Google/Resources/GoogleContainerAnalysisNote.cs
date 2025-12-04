using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority in GoogleContainerAnalysisNote.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAnalysisNoteAttestationAuthorityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attestation_authority";

    /// <summary>
    /// Hint block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hint is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Hint block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hint block(s) allowed")]
    public required TerraformList<GoogleContainerAnalysisNoteAttestationAuthorityBlockHintBlock> Hint
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAnalysisNoteAttestationAuthorityBlockHintBlock>>("hint");
        set => SetArgument("hint", value);
    }

}

/// <summary>
/// Block type for hint in GoogleContainerAnalysisNoteAttestationAuthorityBlock.
/// Nesting mode: list
/// </summary>
public class GoogleContainerAnalysisNoteAttestationAuthorityBlockHintBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hint";

    /// <summary>
    /// The human readable name of this Attestation Authority, for
    /// example &amp;quot;qa&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanReadableName is required")]
    public required TerraformValue<string> HumanReadableName
    {
        get => GetArgument<TerraformValue<string>>("human_readable_name");
        set => SetArgument("human_readable_name", value);
    }

}


/// <summary>
/// Block type for related_url in GoogleContainerAnalysisNote.
/// Nesting mode: set
/// </summary>
public class GoogleContainerAnalysisNoteRelatedUrlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "related_url";

    /// <summary>
    /// Label to describe usage of the URL
    /// </summary>
    public TerraformValue<string>? Label
    {
        get => GetArgument<TerraformValue<string>>("label");
        set => SetArgument("label", value);
    }

    /// <summary>
    /// Specific URL associated with the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleContainerAnalysisNote.
/// Nesting mode: single
/// </summary>
public class GoogleContainerAnalysisNoteTimeoutsBlock : TerraformBlock
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
/// Represents a google_container_analysis_note Terraform resource.
/// Manages a google_container_analysis_note resource.
/// </summary>
public partial class GoogleContainerAnalysisNote(string name) : TerraformResource("google_container_analysis_note", name)
{
    /// <summary>
    /// Time of expiration for this note. Leave empty if note does not expire.
    /// </summary>
    public TerraformValue<string>? ExpirationTime
    {
        get => GetArgument<TerraformValue<string>>("expiration_time");
        set => SetArgument("expiration_time", value);
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
    /// A detailed description of the note
    /// </summary>
    public TerraformValue<string>? LongDescription
    {
        get => GetArgument<TerraformValue<string>>("long_description");
        set => SetArgument("long_description", value);
    }

    /// <summary>
    /// The name of the note.
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
    /// Names of other notes related to this note.
    /// </summary>
    public TerraformSet<string>? RelatedNoteNames
    {
        get => GetArgument<TerraformSet<string>>("related_note_names");
        set => SetArgument("related_note_names", value);
    }

    /// <summary>
    /// A one sentence description of the note.
    /// </summary>
    public TerraformValue<string>? ShortDescription
    {
        get => GetArgument<TerraformValue<string>>("short_description");
        set => SetArgument("short_description", value);
    }

    /// <summary>
    /// The time this note was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The type of analysis this note describes
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The time this note was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// AttestationAuthority block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthority is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthority block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthority block(s) allowed")]
    public required TerraformList<GoogleContainerAnalysisNoteAttestationAuthorityBlock> AttestationAuthority
    {
        get => GetRequiredArgument<TerraformList<GoogleContainerAnalysisNoteAttestationAuthorityBlock>>("attestation_authority");
        set => SetArgument("attestation_authority", value);
    }

    /// <summary>
    /// RelatedUrl block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleContainerAnalysisNoteRelatedUrlBlock>? RelatedUrl
    {
        get => GetArgument<TerraformSet<GoogleContainerAnalysisNoteRelatedUrlBlock>>("related_url");
        set => SetArgument("related_url", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleContainerAnalysisNoteTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleContainerAnalysisNoteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
