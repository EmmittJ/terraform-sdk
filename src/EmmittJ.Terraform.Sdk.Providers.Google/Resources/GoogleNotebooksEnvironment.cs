using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_notebooks_environment resource.
/// </summary>
public class GoogleNotebooksEnvironment : TerraformResource
{
    public GoogleNotebooksEnvironment(string name) : base("google_notebooks_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
    }

    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Display name of this environment for the UI.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A reference to the zone where the machine resides.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name specified for the Environment instance.
    /// Format: projects/{project_id}/locations/{location}/environments/{environmentId}
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance fully boots up.
    /// The path must be a URL or Cloud Storage path. Example: &amp;quot;gs://path-to-file/file-name&amp;quot;
    /// </summary>
    public string? PostStartupScript
    {
        get => GetProperty<TerraformLiteralProperty<string>>("post_startup_script")?.Value;
        set => this.WithProperty("post_startup_script", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Instance creation time
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

}
