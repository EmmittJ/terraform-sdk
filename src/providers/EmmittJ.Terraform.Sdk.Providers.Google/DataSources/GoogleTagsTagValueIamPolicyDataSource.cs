using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_tags_tag_value_iam_policy Terraform data source.
/// Retrieves information about a google_tags_tag_value_iam_policy.
/// </summary>
public partial class GoogleTagsTagValueIamPolicyDataSource(string name) : TerraformDataSource("google_tags_tag_value_iam_policy", name)
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
    /// The tag_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValue is required")]
    public required TerraformValue<string> TagValue
    {
        get => new TerraformReference<string>(this, "tag_value");
        set => SetArgument("tag_value", value);
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
