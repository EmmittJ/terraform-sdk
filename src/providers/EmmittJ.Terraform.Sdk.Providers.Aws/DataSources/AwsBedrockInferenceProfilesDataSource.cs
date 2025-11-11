using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_inference_profiles.
/// </summary>
public class AwsBedrockInferenceProfilesDataSource : TerraformDataSource
{
    public AwsBedrockInferenceProfilesDataSource(string name) : base("aws_bedrock_inference_profiles", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The inference_profile_summaries attribute.
    /// </summary>
    [TerraformPropertyName("inference_profile_summaries")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InferenceProfileSummaries => new TerraformReference(this, "inference_profile_summaries");

}
