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
        get => GetProperty<TerraformProperty<bool>>("embedding_data_delivery_enabled");
        set => WithProperty("embedding_data_delivery_enabled", value);
    }

    /// <summary>
    /// The image_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ImageDataDeliveryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("image_data_delivery_enabled");
        set => WithProperty("image_data_delivery_enabled", value);
    }

    /// <summary>
    /// The text_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? TextDataDeliveryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("text_data_delivery_enabled");
        set => WithProperty("text_data_delivery_enabled", value);
    }

    /// <summary>
    /// The video_data_delivery_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? VideoDataDeliveryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("video_data_delivery_enabled");
        set => WithProperty("video_data_delivery_enabled", value);
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
        this.WithOutput("id");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>? LoggingConfig
    {
        get => GetProperty<List<AwsBedrockModelInvocationLoggingConfigurationLoggingConfigBlock>>("logging_config");
        set => this.WithProperty("logging_config", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
