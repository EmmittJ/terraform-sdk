using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in GoogleGeminiRepositoryGroupIamMember.
/// Nesting mode: list
/// </summary>
public class GoogleGeminiRepositoryGroupIamMemberConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Represents a google_gemini_repository_group_iam_member Terraform resource.
/// Manages a google_gemini_repository_group_iam_member resource.
/// </summary>
public partial class GoogleGeminiRepositoryGroupIamMember(string name) : TerraformResource("google_gemini_repository_group_iam_member", name)
{
    /// <summary>
    /// The code_repository_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CodeRepositoryIndex is required")]
    public required TerraformValue<string> CodeRepositoryIndex
    {
        get => GetArgument<TerraformValue<string>>("code_repository_index");
        set => SetArgument("code_repository_index", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The member attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Member is required")]
    public required TerraformValue<string> Member
    {
        get => GetArgument<TerraformValue<string>>("member");
        set => SetArgument("member", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The repository_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryGroupId is required")]
    public required TerraformValue<string> RepositoryGroupId
    {
        get => GetArgument<TerraformValue<string>>("repository_group_id");
        set => SetArgument("repository_group_id", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleGeminiRepositoryGroupIamMemberConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleGeminiRepositoryGroupIamMemberConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}
