using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock
{
    /// <summary>
    /// The embedding_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("embedding_data_delivery_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EmbeddingDataDeliveryEnabled { get; set; } = default!;

    /// <summary>
    /// The image_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("image_data_delivery_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ImageDataDeliveryEnabled { get; set; } = default!;

    /// <summary>
    /// The text_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("text_data_delivery_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> TextDataDeliveryEnabled { get; set; } = default!;

    /// <summary>
    /// The video_data_delivery_enabled attribute.
    /// </summary>
    [TerraformPropertyName("video_data_delivery_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> VideoDataDeliveryEnabled { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logging_config")]
    public TerraformList<TerraformBlock<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>>? LoggingConfig { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
