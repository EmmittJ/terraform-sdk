using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The embedding_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("embedding_data_delivery_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EmbeddingDataDeliveryEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "embedding_data_delivery_enabled");

    /// <summary>
    /// The image_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_data_delivery_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ImageDataDeliveryEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "image_data_delivery_enabled");

    /// <summary>
    /// The text_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("text_data_delivery_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TextDataDeliveryEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "text_data_delivery_enabled");

    /// <summary>
    /// The video_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("video_data_delivery_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> VideoDataDeliveryEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "video_data_delivery_enabled");

}

/// <summary>
/// Manages a aws_bedrock_model_invocation_logging_configuration resource.
/// </summary>
public class AwsBedrockModelInvocationLoggingConfiguration : TerraformResource
{
    public AwsBedrockModelInvocationLoggingConfiguration(string name) : base("aws_bedrock_model_invocation_logging_configuration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>>? LoggingConfig { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
