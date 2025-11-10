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
    public required TerraformProperty<TerraformProperty<string>> ModelId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The customizations_supported attribute.
    /// </summary>
    [TerraformPropertyName("customizations_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> CustomizationsSupported => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "customizations_supported");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The inference_types_supported attribute.
    /// </summary>
    [TerraformPropertyName("inference_types_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> InferenceTypesSupported => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "inference_types_supported");

    /// <summary>
    /// The input_modalities attribute.
    /// </summary>
    [TerraformPropertyName("input_modalities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> InputModalities => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "input_modalities");

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [TerraformPropertyName("model_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModelArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model_arn");

    /// <summary>
    /// The model_name attribute.
    /// </summary>
    [TerraformPropertyName("model_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModelName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "model_name");

    /// <summary>
    /// The output_modalities attribute.
    /// </summary>
    [TerraformPropertyName("output_modalities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> OutputModalities => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "output_modalities");

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformPropertyName("provider_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProviderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provider_name");

    /// <summary>
    /// The response_streaming_supported attribute.
    /// </summary>
    [TerraformPropertyName("response_streaming_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ResponseStreamingSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "response_streaming_supported");

}
