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
    public string? ExpirationTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("expiration_time")?.Value;
        set => this.WithProperty("expiration_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A detailed description of the note
    /// </summary>
    public string? LongDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("long_description")?.Value;
        set => this.WithProperty("long_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the note.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Names of other notes related to this note.
    /// </summary>
    public HashSet<string>? RelatedNoteNames
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("related_note_names")?.Value;
        set => this.WithProperty("related_note_names", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// A one sentence description of the note.
    /// </summary>
    public string? ShortDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("short_description")?.Value;
        set => this.WithProperty("short_description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
