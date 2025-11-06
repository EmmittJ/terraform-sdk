using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firebaserules_release resource.
/// </summary>
public class GoogleFirebaserulesRelease : TerraformResource
{
    public GoogleFirebaserulesRelease(string name) : base("google_firebaserules_release", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("disabled");
        this.DeclareOutput("update_time");
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
    /// Format: `projects/{project_id}/releases/{release_id}`\Firestore Rules Releases will **always** have the name &#39;cloud.firestore&#39;
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist for the `Release` to be created.
    /// </summary>
    public string? RulesetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ruleset_name")?.Value;
        set => this.WithProperty("ruleset_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. Time the release was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Disable the release to keep it from being served. The response code of NOT_FOUND will be given for executables generated from this Release.
    /// </summary>
    public TerraformExpression Disabled => this["disabled"];

    /// <summary>
    /// Output only. Time the release was updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
