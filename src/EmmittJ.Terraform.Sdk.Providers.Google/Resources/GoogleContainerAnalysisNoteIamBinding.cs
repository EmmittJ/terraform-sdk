using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_container_analysis_note_iam_binding resource.
/// </summary>
public class GoogleContainerAnalysisNoteIamBinding : TerraformResource
{
    public GoogleContainerAnalysisNoteIamBinding(string name) : base("google_container_analysis_note_iam_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
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
    /// The members attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Members
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// The note attribute.
    /// </summary>
    public TerraformProperty<string>? Note
    {
        get => GetProperty<TerraformProperty<string>>("note");
        set => this.WithProperty("note", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
