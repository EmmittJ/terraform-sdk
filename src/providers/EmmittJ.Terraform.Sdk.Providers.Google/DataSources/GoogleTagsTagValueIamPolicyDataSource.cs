using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_tags_tag_value_iam_policy.
/// </summary>
public class GoogleTagsTagValueIamPolicyDataSource : TerraformDataSource
{
    public GoogleTagsTagValueIamPolicyDataSource(string name) : base("google_tags_tag_value_iam_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The tag_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValue is required")]
    [TerraformPropertyName("tag_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TagValue { get; set; }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [TerraformPropertyName("policy_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PolicyData => new TerraformReference(this, "policy_data");

}
