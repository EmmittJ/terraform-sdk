using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_foundation_models.
/// </summary>
public partial class AwsBedrockFoundationModelsDataSource : TerraformDataSource
{
    public AwsBedrockFoundationModelsDataSource(string name) : base("aws_bedrock_foundation_models", name)
    {
    }

    /// <summary>
    /// The by_customization_type attribute.
    /// </summary>
    [TerraformProperty("by_customization_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ByCustomizationType { get; set; }

    /// <summary>
    /// The by_inference_type attribute.
    /// </summary>
    [TerraformProperty("by_inference_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ByInferenceType { get; set; }

    /// <summary>
    /// The by_output_modality attribute.
    /// </summary>
    [TerraformProperty("by_output_modality")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ByOutputModality { get; set; }

    /// <summary>
    /// The by_provider attribute.
    /// </summary>
    [TerraformProperty("by_provider")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ByProvider { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The model_summaries attribute.
    /// </summary>
    [TerraformProperty("model_summaries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ModelSummaries { get; }

}
