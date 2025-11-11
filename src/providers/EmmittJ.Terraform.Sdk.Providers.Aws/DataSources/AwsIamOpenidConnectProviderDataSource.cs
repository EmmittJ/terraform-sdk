using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_openid_connect_provider.
/// </summary>
public partial class AwsIamOpenidConnectProviderDataSource : TerraformDataSource
{
    public AwsIamOpenidConnectProviderDataSource(string name) : base("aws_iam_openid_connect_provider", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Url { get; set; }

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    [TerraformProperty("client_id_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ClientIdList { get; }

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    [TerraformProperty("thumbprint_list")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ThumbprintList { get; }

}
