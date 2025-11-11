using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_openid_connect_provider resource.
/// </summary>
public class AwsIamOpenidConnectProvider : TerraformResource
{
    public AwsIamOpenidConnectProvider(string name) : base("aws_iam_openid_connect_provider", name)
    {
    }

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientIdList is required")]
    [TerraformPropertyName("client_id_list")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> ClientIdList { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_list")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ThumbprintList { get; set; } = default!;

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
