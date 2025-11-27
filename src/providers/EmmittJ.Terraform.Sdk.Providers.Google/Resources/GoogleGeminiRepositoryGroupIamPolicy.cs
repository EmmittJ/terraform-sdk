using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_gemini_repository_group_iam_policy Terraform resource.
/// Manages a google_gemini_repository_group_iam_policy resource.
/// </summary>
public partial class GoogleGeminiRepositoryGroupIamPolicy(string name) : TerraformResource("google_gemini_repository_group_iam_policy", name)
{
    /// <summary>
    /// The code_repository_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndex is required")]
    public required TerraformValue<string> CodeRepositoryIndex
    {
        get => new TerraformReference<string>(this, "code_repository_index");
        set => SetArgument("code_repository_index", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The repository_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryGroupId is required")]
    public required TerraformValue<string> RepositoryGroupId
    {
        get => new TerraformReference<string>(this, "repository_group_id");
        set => SetArgument("repository_group_id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

}
