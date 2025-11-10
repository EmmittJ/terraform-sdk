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
        get => GetProperty<TerraformProperty<string>>("label");
        set => WithProperty("label", value);
    }

    /// <summary>
    /// Specific URL associated with the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
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
        this.DeclareOutput("create_time");
        this.DeclareOutput("kind");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Time of expiration for this note. Leave empty if note does not expire.
    /// </summary>
    public TerraformProperty<string>? ExpirationTime
    {
        get => GetProperty<TerraformProperty<string>>("expiration_time");
        set => this.WithProperty("expiration_time", value);
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
    /// A detailed description of the note
    /// </summary>
    public TerraformProperty<string>? LongDescription
    {
        get => GetProperty<TerraformProperty<string>>("long_description");
        set => this.WithProperty("long_description", value);
    }

    /// <summary>
    /// The name of the note.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// Names of other notes related to this note.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RelatedNoteNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("related_note_names");
        set => this.WithProperty("related_note_names", value);
    }

    /// <summary>
    /// A one sentence description of the note.
    /// </summary>
    public TerraformProperty<string>? ShortDescription
    {
        get => GetProperty<TerraformProperty<string>>("short_description");
        set => this.WithProperty("short_description", value);
    }

    /// <summary>
    /// Block for attestation_authority.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AttestationAuthority block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AttestationAuthority block(s) allowed")]
    public List<GoogleContainerAnalysisNoteAttestationAuthorityBlock>? AttestationAuthority
    {
        get => GetProperty<List<GoogleContainerAnalysisNoteAttestationAuthorityBlock>>("attestation_authority");
        set => this.WithProperty("attestation_authority", value);
    }

    /// <summary>
    /// Block for related_url.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleContainerAnalysisNoteRelatedUrlBlock>? RelatedUrl
    {
        get => GetProperty<HashSet<GoogleContainerAnalysisNoteRelatedUrlBlock>>("related_url");
        set => this.WithProperty("related_url", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleContainerAnalysisNoteTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleContainerAnalysisNoteTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
