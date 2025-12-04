using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleFirebaserulesRelease.
/// Nesting mode: single
/// </summary>
public class GoogleFirebaserulesReleaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a google_firebaserules_release Terraform resource.
/// Manages a google_firebaserules_release resource.
/// </summary>
public partial class GoogleFirebaserulesRelease(string name) : TerraformResource("google_firebaserules_release", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Format: `projects/{project_id}/releases/{release_id}`\Firestore Rules Releases will **always** have the name &#39;cloud.firestore&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Name of the `Ruleset` referred to by this `Release`. The `Ruleset` must exist for the `Release` to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesetName is required")]
    public required TerraformValue<string> RulesetName
    {
        get => GetArgument<TerraformValue<string>>("ruleset_name");
        set => SetArgument("ruleset_name", value);
    }

    /// <summary>
    /// Output only. Time the release was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Disable the release to keep it from being served. The response code of NOT_FOUND will be given for executables generated from this Release.
    /// </summary>
    public TerraformValue<bool> Disabled
        => AsReference("disabled");

    /// <summary>
    /// Output only. Time the release was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFirebaserulesReleaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFirebaserulesReleaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
