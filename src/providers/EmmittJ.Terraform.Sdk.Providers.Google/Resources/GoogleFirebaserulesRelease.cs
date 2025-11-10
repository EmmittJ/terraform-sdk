using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFirebaserulesReleaseTimeoutsBlock : TerraformBlock
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

}

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
        SetOutput("create_time");
        SetOutput("disabled");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("name");
        SetOutput("project");
        SetOutput("ruleset_name");
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
    /// Format: `projects/{project_id}/releases/{release_id}`\Firestore Rules Releases will **always** have the name &#39;cloud.firestore&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist for the `Release` to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesetName is required")]
    public required TerraformProperty<string> RulesetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ruleset_name");
        set => SetProperty("ruleset_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFirebaserulesReleaseTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
