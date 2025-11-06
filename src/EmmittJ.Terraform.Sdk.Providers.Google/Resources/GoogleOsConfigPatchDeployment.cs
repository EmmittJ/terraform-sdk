using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_os_config_patch_deployment resource.
/// </summary>
public class GoogleOsConfigPatchDeployment : TerraformResource
{
    public GoogleOsConfigPatchDeployment(string name) : base("google_os_config_patch_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("last_execute_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Description of the patch deployment. Length of the description is limited to 1024 characters.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Duration of the patch. After the duration ends, the patch times out.
    /// A duration in seconds with up to nine fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;
    /// </summary>
    public string? Duration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("duration")?.Value;
        set => this.WithProperty("duration", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A name for the patch deployment in the project. When creating a name the following rules apply:
    /// * Must contain only lowercase letters, numbers, and hyphens.
    /// * Must start with a letter.
    /// * Must be between 1-63 characters.
    /// * Must end with a number or a letter.
    /// * Must be unique within the project.
    /// </summary>
    public string? PatchDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("patch_deployment_id")?.Value;
        set => this.WithProperty("patch_deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Time the patch deployment was created. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The last time a patch job was started by this deployment. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression LastExecuteTime => this["last_execute_time"];

    /// <summary>
    /// Unique name for the patch deployment resource in a project.
    /// The patch deployment name is in the form: projects/{project_id}/patchDeployments/{patchDeploymentId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Time the patch deployment was last updated. Timestamp is in RFC3339 text format.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds. Example: &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
