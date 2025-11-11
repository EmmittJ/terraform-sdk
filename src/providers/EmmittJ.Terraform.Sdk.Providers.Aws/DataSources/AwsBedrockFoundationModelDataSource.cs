using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_foundation_model.
/// </summary>
public partial class AwsBedrockFoundationModelDataSource : TerraformDataSource
{
    public AwsBedrockFoundationModelDataSource(string name) : base("aws_bedrock_foundation_model", name)
    {
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    [TerraformProperty("model_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ModelId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The customizations_supported attribute.
    /// </summary>
    [TerraformProperty("customizations_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> CustomizationsSupported { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The inference_types_supported attribute.
    /// </summary>
    [TerraformProperty("inference_types_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> InferenceTypesSupported { get; }

    /// <summary>
    /// The input_modalities attribute.
    /// </summary>
    [TerraformProperty("input_modalities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> InputModalities { get; }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [TerraformProperty("model_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModelArn { get; }

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [TerraformProperty("model_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModelName { get; }

    /// <summary>
    /// The output_modalities attribute.
    /// </summary>
    [TerraformProperty("output_modalities")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> OutputModalities { get; }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformProperty("provider_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProviderName { get; }

    /// <summary>
    /// The response_streaming_supported attribute.
    /// </summary>
    [TerraformProperty("response_streaming_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ResponseStreamingSupported { get; }

}
