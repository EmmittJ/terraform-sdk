using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_analysis_occurrence resource.
/// </summary>
public class GoogleContainerAnalysisOccurrence : TerraformResource
{
    public GoogleContainerAnalysisOccurrence(string name) : base("google_container_analysis_occurrence", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("kind");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
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
    /// The analysis note associated with this occurrence, in the form of
    /// projects/[PROJECT]/notes/[NOTE_ID]. This field can be used as a
    /// filter in list requests.
    /// </summary>
    public TerraformProperty<string>? NoteName
    {
        get => GetProperty<TerraformProperty<string>>("note_name");
        set => this.WithProperty("note_name", value);
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
    /// A description of actions that can be taken to remedy the note.
    /// </summary>
    public TerraformProperty<string>? Remediation
    {
        get => GetProperty<TerraformProperty<string>>("remediation");
        set => this.WithProperty("remediation", value);
    }

    /// <summary>
    /// Required. Immutable. A URI that represents the resource for which
    /// the occurrence applies. For example,
    /// https://gcr.io/project/image@sha256:123abc for a Docker image.
    /// </summary>
    public TerraformProperty<string>? ResourceUri
    {
        get => GetProperty<TerraformProperty<string>>("resource_uri");
        set => this.WithProperty("resource_uri", value);
    }

    /// <summary>
    /// The time when the repository was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The note kind which explicitly denotes which of the occurrence
    /// details are specified. This field can be used as a filter in list
    /// requests.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The name of the occurrence.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time when the repository was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
