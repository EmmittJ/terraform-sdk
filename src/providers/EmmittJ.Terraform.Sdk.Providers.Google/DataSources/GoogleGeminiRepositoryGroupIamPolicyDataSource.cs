using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_gemini_repository_group_iam_policy Terraform data source.
/// Retrieves information about a google_gemini_repository_group_iam_policy.
/// </summary>
public partial class GoogleGeminiRepositoryGroupIamPolicyDataSource(string name) : TerraformDataSource("google_gemini_repository_group_iam_policy", name)
{
    /// <summary>
    /// The code_repository_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndex is required")]
    public required TerraformValue<string> CodeRepositoryIndex
    {
        get => GetRequiredArgument<TerraformValue<string>>("code_repository_index");
        set => SetArgument("code_repository_index", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? CreateReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The repository_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryGroupId is required")]
    public required TerraformValue<string> RepositoryGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_group_id");
        set => SetArgument("repository_group_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => CreateReference("policy_data");

}
