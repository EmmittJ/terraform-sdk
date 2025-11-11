using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_openid_connect_provider.
/// </summary>
public class AwsIamOpenidConnectProviderDataSource : TerraformDataSource
{
    public AwsIamOpenidConnectProviderDataSource(string name) : base("aws_iam_openid_connect_provider", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformPropertyName("url")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Url { get; set; } = default!;

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    [TerraformPropertyName("client_id_list")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ClientIdList => new TerraformReference(this, "client_id_list");

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint_list")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ThumbprintList => new TerraformReference(this, "thumbprint_list");

}
