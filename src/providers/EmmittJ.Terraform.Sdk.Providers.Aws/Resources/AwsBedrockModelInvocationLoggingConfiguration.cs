using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The embedding_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? EmbeddingDataDeliveryEnabled
    {
        set => SetProperty("embedding_data_delivery_enabled", value);
    }

    /// <summary>
    /// The image_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageDataDeliveryEnabled
    {
        set => SetProperty("image_data_delivery_enabled", value);
    }

    /// <summary>
    /// The text_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TextDataDeliveryEnabled
    {
        set => SetProperty("text_data_delivery_enabled", value);
    }

    /// <summary>
    /// The video_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VideoDataDeliveryEnabled
    {
        set => SetProperty("video_data_delivery_enabled", value);
    }

}

/// <summary>
/// Manages a aws_bedrock_model_invocation_logging_configuration resource.
/// </summary>
public class AwsBedrockModelInvocationLoggingConfiguration : TerraformResource
{
    public AwsBedrockModelInvocationLoggingConfiguration(string name) : base("aws_bedrock_model_invocation_logging_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
