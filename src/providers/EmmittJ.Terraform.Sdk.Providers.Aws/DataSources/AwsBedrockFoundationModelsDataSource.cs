using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_foundation_models.
/// </summary>
public class AwsBedrockFoundationModelsDataSource : TerraformDataSource
{
    public AwsBedrockFoundationModelsDataSource(string name) : base("aws_bedrock_foundation_models", name)
    {
    }

    /// <summary>
    /// The by_customization_type attribute.
    /// </summary>
    [TerraformPropertyName("by_customization_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ByCustomizationType { get; set; }

    /// <summary>
    /// The by_inference_type attribute.
    /// </summary>
    [TerraformPropertyName("by_inference_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ByInferenceType { get; set; }

    /// <summary>
    /// The by_output_modality attribute.
    /// </summary>
    [TerraformPropertyName("by_output_modality")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ByOutputModality { get; set; }

    /// <summary>
    /// The by_provider attribute.
    /// </summary>
    [TerraformPropertyName("by_provider")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ByProvider { get; set; }

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
