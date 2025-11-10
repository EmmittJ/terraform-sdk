using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attestation_authority in .
/// Nesting mode: list
/// </summary>
public class GoogleContainerAnalysisNoteAttestationAuthorityBlock : TerraformBlock
{
}

/// <summary>
/// Block type for related_url in .
/// Nesting mode: set
/// </summary>
public class GoogleContainerAnalysisNoteRelatedUrlBlock : TerraformBlock
{
    /// <summary>
    /// Label to describe usage of the URL
    /// </summary>
    public TerraformProperty<string>? Label
    {
        set => SetProperty("label", value);
    }

    /// <summary>
    /// Specific URL associated with the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleContainerAnalysisNoteTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_container_analysis_note resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleContainerAnalysisNote : TerraformResource
{
    public GoogleContainerAnalysisNote(string name) : base("google_container_analysis_note", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("kind");
        SetOutput("update_time");
        SetOutput("expiration_time");
        SetOutput("id");
        SetOutput("long_description");
        SetOutput("name");
        SetOutput("project");
        SetOutput("related_note_names");
        SetOutput("short_description");
    }

    /// <summary>
    /// Time of expiration for this note. Leave empty if note does not expire.
    /// </summary>
    public TerraformProperty<string> ExpirationTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_time");
        set => SetProperty("expiration_time", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A detailed description of the note
    /// </summary>
    public TerraformProperty<string> LongDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("long_description");
        set => SetProperty("long_description", value);
    }

    /// <summary>
    /// The name of the note.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Names of other notes related to this note.
    /// </summary>
    public HashSet<TerraformProperty<string>> RelatedNoteNames
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("related_note_names");
        set => SetProperty("related_note_names", value);
    }

    /// <summary>
    /// A one sentence description of the note.
    /// </summary>
    public TerraformProperty<string> ShortDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("short_description");
        set => SetProperty("short_description", value);
    }

    /// <summary>
    /// Block for attestation_authority.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttestationAuthority is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthority block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthority block(s) allowed")]
    public List<GoogleContainerAnalysisNoteAttestationAuthorityBlock>? AttestationAuthority
    {
        set => SetProperty("attestation_authority", value);
    }

    /// <summary>
    /// Block for related_url.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleContainerAnalysisNoteRelatedUrlBlock>? RelatedUrl
    {
        set => SetProperty("related_url", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAnalysisNoteTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time this note was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The type of analysis this note describes
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The time this note was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
