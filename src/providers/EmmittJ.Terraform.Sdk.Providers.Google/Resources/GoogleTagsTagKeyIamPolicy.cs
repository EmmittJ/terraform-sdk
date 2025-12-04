using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_tags_tag_key_iam_policy Terraform resource.
/// Manages a google_tags_tag_key_iam_policy resource.
/// </summary>
public partial class GoogleTagsTagKeyIamPolicy(string name) : TerraformResource("google_tags_tag_key_iam_policy", name)
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => GetArgument<TerraformValue<string>>("policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    public required TerraformValue<string> TagKey
    {
        get => GetArgument<TerraformValue<string>>("tag_key");
        set => SetArgument("tag_key", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

}
