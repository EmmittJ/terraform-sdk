using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_tags_tag_key_iam_policy Terraform data source.
/// Retrieves information about a google_tags_tag_key_iam_policy.
/// </summary>
public partial class GoogleTagsTagKeyIamPolicyDataSource(string name) : TerraformDataSource("google_tags_tag_key_iam_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    public required TerraformValue<string> TagKey
    {
        get => new TerraformReference<string>(this, "tag_key");
        set => SetArgument("tag_key", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}
