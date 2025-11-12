using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock() : TerraformBlock("logging_config")
{
    /// <summary>
    /// The embedding_data_delivery_enabled attribute.
    /// </summary>
    [TerraformProperty("embedding_data_delivery_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EmbeddingDataDeliveryEnabled { get; set; }

    /// <summary>
    /// The image_data_delivery_enabled attribute.
    /// </summary>
    [TerraformProperty("image_data_delivery_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ImageDataDeliveryEnabled { get; set; }

    /// <summary>
    /// The text_data_delivery_enabled attribute.
    /// </summary>
    [TerraformProperty("text_data_delivery_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TextDataDeliveryEnabled { get; set; }

    /// <summary>
    /// The video_data_delivery_enabled attribute.
    /// </summary>
    [TerraformProperty("video_data_delivery_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> VideoDataDeliveryEnabled { get; set; }

}

/// <summary>
/// Manages a aws_bedrock_model_invocation_logging_configuration resource.
/// </summary>
public partial class AwsBedrockModelInvocationLoggingConfiguration : TerraformResource
{
    public AwsBedrockModelInvocationLoggingConfiguration(string name) : base("aws_bedrock_model_invocation_logging_configuration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("logging_config")]
    public TerraformList<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock> LoggingConfig { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
