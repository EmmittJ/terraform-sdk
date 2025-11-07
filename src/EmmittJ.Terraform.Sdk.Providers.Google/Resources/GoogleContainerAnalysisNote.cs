using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_analysis_note resource.
/// </summary>
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
    public TerraformProperty<string>? Name
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
    /// Names of other notes related to this note.
    /// </summary>
    public TerraformProperty<HashSet<string>>? RelatedNoteNames
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("related_note_names");
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
