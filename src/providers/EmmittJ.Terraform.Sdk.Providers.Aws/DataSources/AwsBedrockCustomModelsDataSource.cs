using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_custom_models.
/// </summary>
public class AwsBedrockCustomModelsDataSource : TerraformDataSource
{
    public AwsBedrockCustomModelsDataSource(string name) : base("aws_bedrock_custom_models", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The model_summaries attribute.
    /// </summary>
    [TerraformPropertyName("model_summaries")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ModelSummaries => new TerraformReference(this, "model_summaries");

}
