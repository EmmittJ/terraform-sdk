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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The inference_profile_summaries attribute.
    /// </summary>
    [TerraformPropertyName("inference_profile_summaries")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InferenceProfileSummaries => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "inference_profile_summaries");

}
