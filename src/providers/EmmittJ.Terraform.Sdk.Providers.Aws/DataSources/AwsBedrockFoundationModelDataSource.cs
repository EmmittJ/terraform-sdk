using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_bedrock_foundation_model.
/// </summary>
public class AwsBedrockFoundationModelDataSource : TerraformDataSource
{
    public AwsBedrockFoundationModelDataSource(string name) : base("aws_bedrock_foundation_model", name)
    {
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelId is required")]
    [TerraformPropertyName("model_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ModelId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The customizations_supported attribute.
    /// </summary>
    [TerraformPropertyName("customizations_supported")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> CustomizationsSupported => new TerraformReference(this, "customizations_supported");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The inference_types_supported attribute.
    /// </summary>
    [TerraformPropertyName("inference_types_supported")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> InferenceTypesSupported => new TerraformReference(this, "inference_types_supported");

    /// <summary>
    /// The input_modalities attribute.
    /// </summary>
    [TerraformPropertyName("input_modalities")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> InputModalities => new TerraformReference(this, "input_modalities");

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [TerraformPropertyName("model_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModelArn => new TerraformReference(this, "model_arn");

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [TerraformPropertyName("model_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModelName => new TerraformReference(this, "model_name");

    /// <summary>
    /// The output_modalities attribute.
    /// </summary>
    [TerraformPropertyName("output_modalities")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> OutputModalities => new TerraformReference(this, "output_modalities");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProviderName => new TerraformReference(this, "provider_name");

    /// <summary>
    /// The response_streaming_supported attribute.
    /// </summary>
    [TerraformPropertyName("response_streaming_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ResponseStreamingSupported => new TerraformReference(this, "response_streaming_supported");

}
